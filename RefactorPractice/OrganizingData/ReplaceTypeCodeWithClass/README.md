## 以類別取代型別代碼(Replace TypeCode With Class)

Class之中有一個數值型別代碼(numberic type code)，但它不影響class行為。

以一個新的class替換該數值型別代碼(type code)

## 優點：
* 符號名稱只是別名，編譯器會進行型別檢驗的還是背後的那個數值。
  任何會接受type code作為引數的函式，所期望的還是一個數值，無法強制使用符號名稱，這會降低程式可讀性




