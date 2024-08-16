= 报表技术方案

* 目的

. 解决连表查询缓慢
. 解决数据量过大查询缓慢
. 尽量降低延迟


== 方案1

[plantuml]
....

@startuml

MySql -> ClickHouse: 基于 MaterializeMySQL

@enduml


....


* 优点

. 基于Binlog同步
. 延迟极低（毫秒级）
. 结构实时与ClickHouse保持一致
. 开发语句与mysql类似，对开发友好
. 查询效率高比ES还高
. 高可用
. 接入便捷

* 缺点

. 内存资源消耗大
. 运维成本大
. 分词实现繁琐
. 在无其他条件时匹配查询较慢


== 方案2



[plantuml]
....
@startuml

MySql -> Confluent: 基于语句或Binlog ,将数据定入到Kafka

ElasticSearch --> ElasticSearch : 配置Mapper

Confluent -> ElasticSearch : 通过 kafka to es connetor 写到es 

@enduml

....

* 操作
. 创建es 索引 指定的mapper
. 编写Slq语句，在Confluent中开启任务，将数据写到kafka

. 运行kafka to es connector 将kafka中数据写到es


* 优点

. 可以基于Binlog也可以基于Sql语句（灵活）
. 接入较便捷
. 延迟一般1-3秒7
. 支持分词、自然语义分析、汉字首字母拼音转换
. 可按规则调整分数（权重）

* 缺点

. 高峰或大量数据变更延迟会达到分钟级
. 引入Kafka消息组件，增加复杂度


== 方案3

[plantuml]
....
@startuml

MySql -> HiVe : 通过Sqoop将数据导入到外部表 



@enduml

....

* 操作
. 编写Sql语句
. 启动sqoopjob
. 数据写入文件，指定文件格式
. 使用hive的外部表关连文件

* 优点

. 支持海量数据

* 缺点
. 引入Hadoop
. 延迟非常高，常用作离线数据处理


== 方案4

[plantuml]
....

@startuml

MySql -> SparkSql : 可自定Sql语句

ElasticSearch -> ElasticSearch : 创建Mapper

SparkSql -> ElasticSearch : 通过JDBC写入

@enduml

....


* 操作
. 创建Es 索引 ，指定mapper
. spark-sql通过jdbc，不同维度跑数据，按流程写入es宽表

* 优点
. 灵活,支持JDBC处理
. 数据变换组装方便

* 缺点
. 延迟相对高(秒级)



== ClickHouse VS ElasticSearch 

* 单表查询

image::image/es_vs_ch_01.png[]


* 多表join

image::image/es_vs_ch_02.png[]

