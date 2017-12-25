## 以委託取代繼承 (Replace Inheritance With Delegation)

某個subclass只使用superclass介面的一部分，或是根本不需要繼承來的資料

在subclass中新建一個欄位保存superclass，調整subclass使他改而委託superclass，然後去掉兩者之間的繼承關係

## 優點：
* 以委託取代繼承，可以清楚的表明，只需要受託類別的哪一些部分




