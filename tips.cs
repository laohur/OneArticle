
gti status 
git add *

visual studio

 Ctrl + K ,  Ctrl + D.  自动整理代码 


VS注释与取消注释快捷键

CTRL + K , CTRL + C(注释)

CTRL + K , CTRL + U(取消注释)


Jiangang zhu    ner
xiangli     process


F12 查看定义
Ctrl-  返回

Trace.WriteLine()将有关跟踪的信息写入 Listeners 集合中的跟踪侦听器
Debug.WriteLine()只有调试的时候才输出。


调试（启动）：F5；

调试（重新启动）：使用组合键“Ctrl+Shift+F5”；

调试（开始执行不调试）：使用组合键“Ctrl+F5”；

调试（逐语句）：F11；（进入到一个函数的源码中）

调试（逐过程）：F10；（一行一行往下跳）

设置断点：F9。

        查找某一个词：ctrl+F

     跳转到指定的某一行：ctrl+G

     隔了一个星期，再来补充点：当有错误时，想要查找源文件，按ctrl+shift+alt+o
--------------------- 
作者：TX98337 
来源：CSDN 
原文：https://blog.csdn.net/TX98337/article/details/52526009 
版权声明：本文为博主原创文章，转载请附上博文链接！

 Linux下复制粘贴快捷键

 1. 在终端下：

          复制命令：Ctrl + Shift + C  组合键.

          粘贴命令：Ctrl + Shift + V  组合键.

 

 2. 在控制台下：

          复制命令：Ctrl + Insert  组合键　　或　　用鼠标选中即是复制。

          粘贴命令：Shift + Insert  组合键　　或　　单击鼠标滚轮即为粘贴。

 

 
var result = (await Task.WhenAll(tasks)).Where(x => x != null).Select(x =>
        new AnalyzeQueryResponse
        {
                SemanticFrames = x.ToExternal()
        }).ToArray();

var result = (await Task.WhenAll(tasks)).Where(x => x != null).Foreach(x =>
     {   return  new AnalyzeQueryResponse
        {
                SemanticFrames = x.ToExternal()
        };
         
     }  
        ).ToArray();
