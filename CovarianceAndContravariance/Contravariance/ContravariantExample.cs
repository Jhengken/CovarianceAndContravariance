using CovarianceAndContravariance.Covariance;

namespace CovarianceAndContravariance.Contravariance
{
    public class ContravariantExample : IContravariant<Animal>
    {
        public void SetItem(Animal item)
        {
            // 處理 Animal
        }
    }
}

