# Unity3D-homework10
# 双人赛车
### -----Scripts
### -----Readme.md  
  
录像地址：https://pan.baidu.com/s/1OBhkThg6pdPFmh-ecmRgeQ  
完整游戏文件：  

游戏介绍：  
这是一个使用分屏方式实现的多人局域网游戏，场景直接在本地生成，游戏对象（玩家）按照老师上课上用的方法创建。每个玩家都可以看到自己和对手的视角，自己的赛车用红色区别开，赛车与终点线碰撞触发GameOver，读秒阶段赛车不能移动。  
方向键上下（加速/刹车），左右转向。  

游戏bug：  
目前游戏的bug还是比较多的，比如赛车容易冲出跑道，倒车时的方向问题。  
同时，也有消耗系统资源过多的问题。  
  
资源说明：  
赛车资源用的是unity自带的car预制，将其代码部分作了一定的修改。赛道用的是资源商店里下载的，截图如下：  
![](http://m.qpic.cn/psb?/V13Mdii00HOnY3/a5WrMG0lvY06lMJH521S.OL4blEpWtG*HIV*MzAt*s4!/b/dEEBAAAAAAAA&bo=GgOEAQAAAAARF7w!&rf=viewer_4&t=5)  
  
关于代码：  
我只上传了4个有改动的代码，其中关于car的两个文件我重写了部分内容，附加在car预制上；line和MyGUI文件全部是我自己写的，分别附加在line对象和两个car的跟踪摄像机上。  
  
关于场景：  
![](http://m.qpic.cn/psb?/V13Mdii00HOnY3/apb.cLLzMlNnuU2AfDH.j77pcOxbpoewkUgyD*5lBfs!/b/dIMAAAAAAAAA&bo=3wCBAAAAAAADF2w!&rf=viewer_4&t=5)![](http://m.qpic.cn/psb?/V13Mdii00HOnY3/OX7aEOv2Tc6UHyV14NBQtz02*reI2Wg4du6nEhGMLpk!/b/dDABAAAAAAAA&bo=SAF3AAAAAAADFww!&rf=viewer_4&t=5)  
  
