using System.Collections;

namespace OddNumbers;

public class OddGenerator : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        int i = 1;
        yield return i;
        while (true)
        {
            i += 2;
            yield return i;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

