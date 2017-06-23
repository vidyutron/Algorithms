using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.LinkedLists
{
    
    public class SkipListLL<T,U> where T:class, IComparable<T> where U :class
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        private class Node
        {
            private Node _down;
            private T _key;
            private long _level;
            private Node _next;
            private U _value;

            public Node Down { get { return _down; } set { _down = value; } }
            public Node Next { get { return _next; } set { _next = value; } }
            public long Level { get { return _level; } set { _level = value; } }

            public T Key { get { return _key; } set { _key = value; } }
            public U Value { get { return _value; } set { _value = value; } }
            public Node(T key,U value,long level,Node next,Node down)
            {
                _key = key;
                _value = value;
                _level = level;
                _next = next;
                _down = down;
            }
        }

        private Node _head;
        private Random _random;
        private long size;
        private double _p;

        private long Level()
        {
            long level = 0;
            while (level<=size&&_random.NextDouble()<_p)
            {
                level++;
            }
            return level;
        }

        public SkipListLL()
        {
            _head = new Node(null, null, 0, null, null);
            _random = new Random();
            size = 0;
            _p = 0.5;
        }

        public void Add(T key,U value)
        {
            long level = Level();
            if (level > _head.Level) _head = new Node(null, null, level, null, _head);
            var cur = _head;
            Node last = null;
            while (cur!=null)
            {
                if (cur.Next == null || cur.Next.Key.CompareTo(key) > 0)
                {
                    if (level >= cur.Level)
                    {
                        var n = new Node(key, value, cur.Level, cur.Next, null);
                        if (last != null) last.Down = n;
                        cur.Next = n;
                        last = n;
                    }

                    cur = cur.Down;
                    continue;
                }
                else if (cur.Next.Key.Equals(key))
                {
                    cur.Next.Value = value;
                    return;
                }
                cur = cur.Next;
                }
            size++;
            }

        public bool ContainsKey(T key)
        {
            return Get(key) != null;
        }

        public U remove(T key)
        {
            U value = null;
            var cur = _head;
            while (cur!=null)
            {
                if (cur.Next == null || cur.Next.Key.CompareTo(key) >= 0) {
                    if(cur.Next!=null && cur.Next.Key.Equals(key))
                    {
                        value = cur.Next.Value;
                        cur.Next = cur.Next.Next;
                    }

                    cur = cur.Down;
                    continue;
                }
                cur = cur.Next;
            }
            size++;
            return value;
        }

        private U Get(T key)
        {
            var cur = _head;
            while (cur!=null)
            {
                if (cur.Next == null || cur.Next.Key.CompareTo(key) > 0)
                {
                    cur = cur.Down;
                    continue;
                }
                else if (cur.Next.Key.Equals(key)) return cur.Next.Value;
                cur = cur.Next;
            }
            return null;
        }
    }
    }

