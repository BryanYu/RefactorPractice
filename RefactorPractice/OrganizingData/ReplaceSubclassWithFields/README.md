## 以欄位取代子類別(Replace Subclass With Fields)

各個subclasses的差別在於傳回常數的函式身上。

修改這些函式，使他們傳回superclass中的某個(新增欄位)，然後銷毀subclass

## 優點：
* 若subclass中只有常數函式，沒有足夠的存在價值，可以在superclass中設計一個與常數函式回傳值相應的欄位，
  從而完全去除這樣的subclass。




