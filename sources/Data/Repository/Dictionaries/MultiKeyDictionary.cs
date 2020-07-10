/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System.Collections.Generic;

namespace TheSharpFactory.Data.Repository.Common
{

    /// <summary>
    /// This dictionary supports 1 key
    /// </summary>
    public class MultiKeyDictionary<TKey1, TValue>:Dictionary<TKey1, TValue>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity) : base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer) : base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer) : base(capacity, comparer)
        {
        }
        new public void Add(TKey1 k1, TValue val)
        {
            if(!ContainsKey(k1))
                base.Add(k1, val);
        }
    }

    /// <summary>
    /// This dictionary supports 2 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TValue>() { { k2, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2);
        }
    }

    /// <summary>
    /// This dictionary supports 3 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TValue>() { { k2, k3, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3);
        }
    }

    /// <summary>
    /// This dictionary supports 4 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TValue>() { { k2, k3, k4, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4);
        }
    }

    /// <summary>
    /// This dictionary supports 5 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TValue>() { { k2, k3, k4, k5, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5);
        }
    }

    /// <summary>
    /// This dictionary supports 6 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TValue>() { { k2, k3, k4, k5, k6, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6);
        }
    }

    /// <summary>
    /// This dictionary supports 7 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TValue>() { { k2, k3, k4, k5, k6, k7, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7);
        }
    }

    /// <summary>
    /// This dictionary supports 8 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, k8, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TValue>() { { k2, k3, k4, k5, k6, k7, k8, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7, k8);
        }
    }

    /// <summary>
    /// This dictionary supports 9 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, k8, k9, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TValue>() { { k2, k3, k4, k5, k6, k7, k8, k9, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7, k8, k9);
        }
    }

    /// <summary>
    /// This dictionary supports 10 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, k8, k9, k10, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TValue>() { { k2, k3, k4, k5, k6, k7, k8, k9, k10, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7, k8, k9, k10);
        }
    }

    /// <summary>
    /// This dictionary supports 11 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TValue>() { { k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11);
        }
    }

    /// <summary>
    /// This dictionary supports 12 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TValue>() { { k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12);
        }
    }

    /// <summary>
    /// This dictionary supports 13 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12, TKey13 k13, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TValue>() { { k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12, TKey13 k13)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13);
        }
    }

    /// <summary>
    /// This dictionary supports 14 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TKey14, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TKey14, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12, TKey13 k13, TKey14 k14, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TKey14, TValue>() { { k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12, TKey13 k13, TKey14 k14)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14);
        }
    }

    /// <summary>
    /// This dictionary supports 15 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TKey14, TKey15, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TKey14, TKey15, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12, TKey13 k13, TKey14 k14, TKey15 k15, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TKey14, TKey15, TValue>() { { k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12, TKey13 k13, TKey14 k14, TKey15 k15)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15);
        }
    }

    /// <summary>
    /// This dictionary supports 16 keys
    /// </summary>
    public class MultiKeyDictionary<TKey1, TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TKey14, TKey15, TKey16, TValue>:Dictionary<TKey1, MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TKey14, TKey15, TKey16, TValue>>
    {
        public MultiKeyDictionary()
        {
        }
        public MultiKeyDictionary(int capacity):base(capacity)
        {
        }
        public MultiKeyDictionary(IEqualityComparer<TKey1> comparer):base(comparer)
        {
        }
        public MultiKeyDictionary(int capacity, IEqualityComparer<TKey1> comparer):base(capacity, comparer)
        {
        }
        public void Add(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12, TKey13 k13, TKey14 k14, TKey15 k15, TKey16 k16, TValue val)
        {
            if(ContainsKey(k1))
                this[k1].Add(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, k16, val);
            else
                Add(k1, new MultiKeyDictionary<TKey2, TKey3, TKey4, TKey5, TKey6, TKey7, TKey8, TKey9, TKey10, TKey11, TKey12, TKey13, TKey14, TKey15, TKey16, TValue>() { { k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, k16, val } });
        }
        public bool ContainsKey(TKey1 k1, TKey2 k2, TKey3 k3, TKey4 k4, TKey5 k5, TKey6 k6, TKey7 k7, TKey8 k8, TKey9 k9, TKey10 k10, TKey11 k11, TKey12 k12, TKey13 k13, TKey14 k14, TKey15 k15, TKey16 k16)
        {
            return ContainsKey(k1) && this[k1].ContainsKey(k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, k16);
        }
    }
}
