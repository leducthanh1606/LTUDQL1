<Query Kind="Statements" />

var list = new int []{5,4,1,3,9,8,6,7,2,0};

var q = from i in list
		select i+1;
q.Dump();

//Câu 2:
var cau2 = from i in list 
			where (i%2 != 0)
			select i;
cau2.Count().Dump();

//Câu 3
var cau3 = from i in list
			select (i==0? "không":(i==1?"một":(i==2?"hai":(i==3?"ba":(i==4?"bốn":(i==5? "năm":
			(i==6?"sáu":(i==7?"bảy":(i==8?"tám":"chín")))))))));
cau3.Dump();

//Câu 4:
List<string> lst = new List<string> {"aPPLE", "BIUeBeRrY","cHeRry"};
var cau4Up = from i in lst
		   select i.ToUpper();
cau4Up.Dump();
var cau4Lower = from i in lst 
				select i.ToLower();
cau4Lower.Dump();

//Câu 5:var list = new int []{5,4,1,3,9,8,6,7,2,0};
var cau5 = from i in list
			select (i==0? "không":(i==1?"một lẻ":(i==2?"hai chẵn":(i==3?"ba lẻ":(i==4?"bốn chẵn":(i==5? "năm lẻ":
			(i==6?"sáu chẵn":(i==7?"bảy lẻ":(i==8?"tám chẵn":"chín lẻ")))))))));
cau5.Dump();
