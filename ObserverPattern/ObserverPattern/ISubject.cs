﻿namespace ObserverPattern
{
	internal interface ISubject
	{
		void Subscribe(Observer observer);
		void Unsubscribe(Observer observer);
		void Notify();
	}
}