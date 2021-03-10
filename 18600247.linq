<Query Kind="Expression" />

//a. Liệt kê tất cả các số có chữ số tận cùng là 5 và không lớn hơn 1000001.
Enumerable.Range(0,1000002).Where(i=> i % 10 !=0 &&  i % 5 == 0)

//b. Liệt kê tất cả các số nguyên tố nhỏ hơn 1000001.
from i in Enumerable.Range(0,1000002)
where Enumerable.Range(2,i).Count(j=> i % j == 0) == 1
select i

//c. Liệt kê tất cả các số có ít nhất 3 chữ số 7 và nhỏ hơn 1000001.
Enumerable.Range(0,1000002).Where(i => {
var n = 0;
var temp = i;
 while(temp > 0){
 	if(temp % 10 == 7) 
 		n++; 
 	temp /= 10;
 }
return n >= 3;
})

//e.Liệt kê tất cả các số chính phương nhỏ hơn 1000001.
from i in Enumerable.Range(0,1000002)
where i*i < 1000002 && i > 1
select i*i

//d. Liệt kê tất cả các số hoàn chỉnh nhỏ hơn 1000001.
Enumerable.Range(0,1000002).Where(i => {
var tongUoc = 0; 
	for(var j = 1; j < i; j++){
		if(i % j == 0 ) 
			tongUoc = tongUoc + j;
	}
	return tongUoc == i;
})
