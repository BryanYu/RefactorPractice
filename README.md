# RefactorPractice
重構-改善既有程式的設計Lab

使用C#改寫書上的範例

## 重構的定義：
不改變外在的行為的前提下，對程式碼做出修正，以改進程式的內部結構。本質上來說，重構就是在`程式碼寫好之後改進它的設計`

## 重構的原則：
* 需要有穩定且堅固的測試機制
* 以微小步伐修改程式，如果引入錯誤便可以很容易發現
* 如果覺得比較困難增加新的功能，就先重構後再增加
* 只有寫出人類容易理解的程式碼，才是優秀的程式員

## 兩頂帽子 - 重構與增加新功能
* 增加新功能：不應該修改既有程式碼，只管增加新功能以通過測試
* 重構：不能增加新功能，只管修改程式結構。只在絕對必要的時刻才修改測試。

## 為何要重構?
* 改進軟體設計：一個主要的方向就是`消除重複的程式碼`。
* 使軟體更容易被理解：提高可讀性。
* 幫你找到Bug
* 幫你提高編程速度

## 何時重構?
* 三次法則：事不過三，三則重構
* 增加功能的時候重構
* 修改錯誤的時候重構
* Code Review的時候重構

## 程式碼的壞味道(Bad Smell)
* 重複的程式碼(Duplicated Code)
* 過長的函式(Long Method)
* 過大的類別(Large Class)
* 過長的參數列(Large Parameter List)
* 發散式變化(Divergent Change)
* 散彈式修改(Shotgun Surgery)
* 依戀情節(Feature Envy)
* 資料泥團(Data Clump)
* 基本型別偏執(Primitive Obsession)
* Switch case 
* 平行繼承體系(Parallel Inheritance Hierarchies)
* 冗員類別(Lazy Class)
* 誇大其談未來性(Speculative Generality)
* 暫時欄位(Temporary Field)
* 過度耦合的訊息鏈(Message Chains)
* 中間轉手人(Middle Man)
* 狎暱關係(inappropriate Intimacy)
* 異曲同工的類別(Alternative Classes With Different Interfaces)
* 不完美的程式庫類別(Incomplete Library Class)
* 純資料類別(Data Class)
* 被拒絕的遺贈(Refused Bequest)
* 過多的註釋(Comments)

## 重構手法

### 重新組織函式(Composing Methods)
* [提煉函式(Extract Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/ExtractMethod)
* [行內函式(Inline Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/InlineMethod)
* [行內暫時變數(Inline Temp)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/InlineTemp)
* [用回傳函式替換暫時變數(Replace Temp With Query)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/ReplaceTempWithQuery)
* [以變數解釋運算式用途(Introduce Explaining Variable)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/IntroduceExplainingVariable)
* [剖解暫時變數(Split Temporary Variable)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/SplitTemporaryVariable)
* [移除對參數賦值(Remove Assignments To Parameters)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/RemoveAssignmentsToParameters)
* [用函式物件替換函式(Replace Method With MethodObject)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/ReplaceMethodWithMethodObject)
* [替換演算法(Substitute Algorithm)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/ComposingMethods/SubstituteAlgorithm)

### 在物件中間搬移特性(Moving Features Between Objects)
* [移動函式(Move Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/MoveMethod)
* [移動欄位(Move Field)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/MoveField)
* [提煉類別(Move Class)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/ExtractClass)
* [行內類別(Inline Class)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/InlineClass)
* [隱藏委託關係(Hide Delegate)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/HideDelegate)
* [移除中間人(Remove Middle Man)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/RemoveMiddleMan)
* [引入外加函式(Introduce Foreign Method)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/IntroduceForeignMethod)
* [引入區域性擴展(Introduce Local Extension)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/MovingFeaturesBetweenObjects/IntroduceLocalExtension)

### 重新組織資料(Organizing Data)
* [自我封裝欄位(Self Encapsulate Field)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/SelfEncapsulateField)
* [以物件取代資料值(Replace Data Value With Object)](https://github.com/BryanYu/RefactorPractice/tree/master/RefactorPractice/OrganizingData/ReplaceDataValueWithObject)