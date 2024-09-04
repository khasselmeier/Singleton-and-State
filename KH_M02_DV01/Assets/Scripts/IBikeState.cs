using Chapter.State;

namespace Chapter.State
{
    public interface IBikeState
    {
        void Handle(BikeController controller);
    }
}
