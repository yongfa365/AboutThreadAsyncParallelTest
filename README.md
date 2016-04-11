# AboutThreadAsyncParallelTest
在服务器能支持大并发的前提下，客户端如何调用才能更快、更省内存、更省线程数据？

结论是：使用Async


## Screenshot:

![Preview 1](https://raw.githubusercontent.com/yongfa365/AboutThreadAsyncParallelTest/master/Snapshot.png)


# MVCTest测试方法：

ab -n 200 -c 100 http://localhost:5782/default/asynctest

测试前不要忘记先让Server高并发，方法是访问：

http://localhost:36020/api/test/Init/100/200
