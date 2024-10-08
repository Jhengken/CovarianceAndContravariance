namespace CovarianceAndContravariance.Covariance;

public interface ICovariant<out T>
{
    T GetItem();
}