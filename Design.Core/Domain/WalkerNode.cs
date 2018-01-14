namespace Design.Core.Domain
{
    public class WalkerNode
    {
        public Node Node { get; protected set; }
        public Walker Walker { get; protected set; }

        protected WalkerNode()
        {
        }

        protected WalkerNode(Walker walker, Node node)
        {
            Walker = walker;
            Node = node;
        }

        public static WalkerNode Create(Walker walker, Node node)
            => new WalkerNode(walker, node);
    }
}