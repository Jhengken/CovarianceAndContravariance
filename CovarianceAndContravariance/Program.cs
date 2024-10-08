using CovarianceAndContravariance.Contravariance;
using CovarianceAndContravariance.Covariance;


// 共變，可以用父類去接子類
ICovariant<Animal> animal = new CovariantExample();
Animal myAnimal = animal.GetItem(); // 可以返回 Dog 型別的物件
//Dog myAnimal2 = animal.GetItem(); // GetItem 無法用 Dog來接
((CovariantExample) animal).Exec1(1, 2); 
((CovariantExample) animal).Exec2(1, 2);


// 反(逆)變，可以用子類去接父類
IContravariant<Dog> dogContravariant = new ContravariantExample();
dogContravariant.SetItem(new Dog()); // 可以接受 Animal 型別的參數


// 因為 List<T> 有實作共變，所以 List1() 可以用 IEnumerable 來接
IEnumerable<string> list1 = List1();
IEnumerable<string> List1()
{
    return new List<string>();
}


string[] stringArray = new string[] {"A","B","C"};
object[] objectArray = stringArray;
// objectArray[0] = new object();
// 上面那行Runtime會噴掉，因為objectArray[0]實際上還是指向stringArray[0]
// (並非像實值boxing複製值那樣，而是「指向同一參考」)
// 但編譯會過的原因是，string是object的衍生類別XDD