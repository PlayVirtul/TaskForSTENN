namespace Program
{
    public class Tree
    {
        public string Name { get; set; }

        public IEnumerable<Tree> Children { get; set; }
    }

    public class Algorithm
    {
        public List<string> ListNames { get; set; } = new List<string>();

        public void PrintTreeName(Tree tree)
        {
            ListNames.Add(tree.Name);

            if (tree.Children == null)
            {
                return;
            }

            foreach (var item in tree.Children)
            {
                PrintTreeName(item);
            }
        }
    }
}