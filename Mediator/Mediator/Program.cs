﻿using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create chatroom
            ChatRoom chatroom = new ChatRoom();

            Participant Eddie = new Actor("Eddie");
            Participant Jennifer = new Actor("Jennifer");
            Participant Bruce = new Actor("Bruce");
            Participant Tom = new Actor("Tom");
            Participant Tony = new NonActor("Tony");

            // Create participants and register them
            chatroom.Register(Eddie);
            chatroom.Register(Jennifer);
            chatroom.Register(Bruce);
            chatroom.Register(Tom);
            chatroom.Register(Tony);

            // Chatting participants
            Tony.Send("Tom", "Hey Tom! I got a mission for you.");
            Jennifer.Send("Bruce", "Teach me to act and I'll" +
                " teach you to dance");
            Bruce.Send("Eddie", "How come you don't do standup anymore?");

            Jennifer.Send("Tom", "Do you like math?");
            Tom.Send("Tony", "Teach me to sing.");

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 'Mediator' Class
    /// </summary>
    abstract class AbstractChatRoom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }

    /// <summary>
    /// 'Concrete Mediator' Class
    /// </summary>
    class ChatRoom : AbstractChatRoom
    {
        public Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;

                participant.Room = this;
            }
        }

        public override void Send(string from, string to, string message)
        {
            Participant participant = _participants[to];

            if(participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }

    /// <summary>
    /// 'Abstract Colleague' Class
    /// </summary>
    class Participant
    {
        private string _name;
        private ChatRoom _chatRoom;

        public Participant(string name)
        {
            _name = name;
        }

        public string Name { get { return _name; } }
        public ChatRoom Room { get { return _chatRoom; } set { _chatRoom = value; } }

        public void Send(string to, string message)
        {
            _chatRoom.Send(_name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: '{message}'");
        }
    }

    /// <summary>
    /// 'ConcreteColleague' Class
    /// </summary>
    class Actor : Participant
    {
        public Actor(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a Actor: ");
            base.Receive(from, message);
        }
    }

    /// <summary>
    /// 'ConcreteColleague' Class
    /// </summary>
    class NonActor : Participant
    {
        public NonActor(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a NonActor: ");
            base.Receive(from, message);
        }
    }
}
