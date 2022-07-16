namespace Program
{
    public class Car : IEquatable<Car>
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public override bool Equals(object? other)
        {
            if (other == null)
            {
                return false;
            }

            if (this.GetType() != other.GetType())
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Equals(other as Car);
        }

        public bool Equals(Car? other)
        {
            if (other == null)
            {
                return false;
            }

            if (string.Compare(this.Model, other.Model, StringComparison.CurrentCulture) == 0
                && string.Compare(this.Color, other.Color, StringComparison.CurrentCulture) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Model, Color);
        }
    }
}