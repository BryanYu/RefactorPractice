## 以State/Strategy取代型別代碼(Replace Type Code With State/Strategy)

有一個type code，它會影響class的行為，但你無法使用subclassing。

以state object(專門描述狀態的物件)取代type code


## 優點：
* 如果type code的值在物件生命週期中發生變化，或其他原因使得宿主類別不能被subclassing，就使用這個原則。




