namespace CovarianceAndContravariance.Contravariance;

public interface IContravariant<in T>
{
    void SetItem(T item);
}