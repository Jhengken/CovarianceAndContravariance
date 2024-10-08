namespace CovarianceAndContravariance.Covariance;

public class CovariantExample : ICovariant<Dog>
{
    public bool Exec1<T>(IEquatable<T>o1 ,IEquatable<T>o2)
    {
        return o1.Equals(o2);
    }
  
    //第二支則是先約束傳入的T要實作IEquatable<T>，所以不會有boxing的可能
    public bool Exec2<T>(T o1 ,T o2) where T : IEquatable<T>
    {
        return o1.Equals(o2);
    }
    public Dog GetItem() 
    {
        return new Dog();
    }
    
}