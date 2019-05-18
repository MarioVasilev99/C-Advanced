using System.Collections;
using System.Collections.Generic;

namespace P04.Froggy
{
    public class Path<T> : IEnumerable<T>
    {
        private List<T> path;

        public Path(List<T> pathList)
        {
            this.path = new List<T>();
            this.path = pathList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.path.Count; i+=2)
            {
                yield return this.path[i];
            }

            int reverseStartIndex = this.path.Count % 2 == 0
                ? reverseStartIndex = this.path.Count - 1
                : reverseStartIndex = this.path.Count - 2;

            for (int i = reverseStartIndex; i >= 0; i-=2)
            {
                yield return this.path[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
