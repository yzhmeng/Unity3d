# homework2 #

## 1.简答题 ##
1. 游戏对象运动的本质，其实是游戏对象跟随每一帧的变化，空间地变化。这里的空间变化包括了游戏对象的transform属性中的position跟rotation两个属性。一个是绝对或者相对位置的改变，一个是所处位置的角度的旋转变化。
2. 
- 方法一：改变Transform的position属性
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190920162433107.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
- 方法二：创建Vector3向量
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190920114129866.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
- 方法三：使用transform.Translate方法
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190920163215901.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
3. 写一个程序，实现一个完整的太阳系， 其他星球围绕太阳的转速必须不一样，且不在一个法平面上。
- 建立结构
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190921164909386.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
- 设置行星大小并在网上找到相应贴图添加到assets
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190921165150423.png)
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190921165206173.png)
- 加入cs脚本，代码如下：
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190921165709954.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
- 效果图
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190921165819141.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
## 2.编程实践 ##
- 阅读以下游戏脚本

> Priests and Devils

> Priests and Devils is a puzzle game in which you will help the Priests and Devils to cross the river within the time limit. There are 3 priests and 3 devils at one side of the river. They all want to get to the other side of this river, but there is only one boat and this boat can only carry two persons each time. And there must be one person steering the boat from one side to the other side. In the flash game, you can click on them to move them and click the go button to move the boat to the other direction. If the priests are out numbered by the devils on either side of the river, they get killed and the game is over. You can try it in many > ways. Keep all priests alive! Good luck!

- 程序需要满足的要求：
  1. play the game (http://www.flash-game.net/game/2535/priests-and-devils.html )
  2. 列出游戏中提及的事物（Objects）
  3. 用表格列出玩家动作表（规则表），注意，动作越少越好
  4. 请将游戏中对象做成预制
  5. 在 GenGameObjects 中创建 长方形、正方形、球 及其色彩代表游戏中的对象。
  6. 使用 C# 集合类型 有效组织对象
  7. 整个游戏仅 主摄像机 和 一个 Empty 对象，其他对象必须代码动态生成！！! 。 整个游戏不许出现 Find       游戏对象， SendMessage 这类突破程序结构的 通讯耦合 语句。 违背本条准则，不给分
  8. 请使用课件架构图编程，不接受非 MVC 结构程序
  9. 注意细节，例如：船未靠岸，牧师与魔鬼上下船运动中，均不能接受用户事件！
- 游戏对象
  - 恶魔（3）
  - 牧师（3）
  - 船（1）
  - 河
  - 河岸
- 结构
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190921225843457.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
- 示例
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190921225913218.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
白色圆柱为牧师，红色圆柱为恶魔。
- 设计实现
在 GenGameObjects 中创建圆柱体，长方体等代表游戏对象详细见代码
![在这里插入图片描述](https://img-blog.csdnimg.cn/2019092123042487.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190921230447961.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)
![在这里插入图片描述](https://img-blog.csdnimg.cn/20190921230513228.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzQwMzMzMjcw,size_16,color_FFFFFF,t_70)

