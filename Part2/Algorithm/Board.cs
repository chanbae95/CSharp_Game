using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Room<T>
    {
        public T Data;
        public Room<T> Next;
        public Room<T> Prev;

    }

    class RoomList<T>
    {
        public Room<T> Head = null;
        public Room<T> Tail = null;
        public int Count = 0;

        public Room<T> AddLast(T data)
        {
            Room<T> newRoom = new Room<T>();
            newRoom.Data = data;

            if (Head == null)
                Head = newRoom;

            //기존의 마지막 방과 새로 추가되는 방을 연결해 준다
            if(Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }
            //새로 추가되는 방을 마지막 방으로 인정한다.
            Tail = newRoom;
            Count++;
            return newRoom;
        }

        public void Remove(Room<T> room)
        {
            //첫번째 방 삭제일때
            if (Head == room)
                Head = Head.Next;

            // 마지막 방 삭제일때
            if (Tail == room)
                Tail = Tail.Prev;

            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;

        }

    }

    class Board
    {
        public int[] _data = new int[25]; // 배열
        public RoomList<int> _data3 = new RoomList<int>(); // 연결 리스트


        public void Initialize()
        {
            _data3.AddLast(101);
            _data3.AddLast(102);
            Room<int> node =  _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }
}
