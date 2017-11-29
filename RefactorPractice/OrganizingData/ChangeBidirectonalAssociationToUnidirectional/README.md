## 將雙向關聯改為單向 (Change Bidirectonal Association To Unidirectional)

兩個Class之間有雙向關聯，當其中一個Class不再需要另一個Class的特性。

就去除不必要的關聯。

## 優點：
* 雙向關聯必須確保物件能正確的被創建與刪除
* 大量的雙向關聯也容易產生殭屍物件
* 雙向關聯迫使兩個Class之間有相依性，過多的相依性會造成緊耦合。




