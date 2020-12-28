from __future__ import annotations
from abc import ABC, abstractmethod, abstractproperty
from typing import Any, List
import random
from unittest import mock
from unittest.mock import *
import unittest


class Builder(ABC):

    @abstractproperty
    def product(self) -> None:
        pass

    @abstractmethod
    def build_floor(self) -> None:
        pass

    @abstractmethod
    def build_walls(self) -> None:
        pass

    @abstractmethod
    def build_roof(self) -> None:
        pass

    @abstractmethod
    def build_garden(self) -> None:
        pass

    @abstractmethod
    def build_pool(self) -> None:
        pass


class Builder1(Builder):

    def __init__(self) -> None:
        self.reset()

    def reset(self) -> None:
        self._product = Product1()

    @property
    def product(self) -> Product1:
        product = self._product
        self.reset()
        return product

    def build_floor(self) -> None:
        self._product.add("Floor")

    def build_walls(self) -> None:
        self._product.add("Walls")

    def build_roof(self) -> None:
        self._product.add("Roof")

    def build_garden(self) -> None:
        self._product.add("Garden")

    def build_pool(self) -> None:
        self._product.add("Pool")


class Product1():

    def __init__(self) -> None:
        self.parts = []

    def add(self, part: Any) -> None:
        self.parts.append(part)

    def list_parts(self) -> None:
        print(f"Product parts: {', '.join(self.parts)}", end="")


class Director:

    def __init__(self) -> None:
        self._builder = None

    @property
    def builder(self) -> Builder:
        return self._builder

    @builder.setter
    def builder(self, builder: Builder) -> None:
        self._builder = builder

    def build_minimal_viable_product(self) -> None:
        self.builder.build_floor()
        self.builder.build_walls()
        self.builder.build_roof()

    def build_full_featured_product(self) -> None:
        self.builder.build_floor()
        self.builder.build_walls()
        self.builder.build_roof()
        self.builder.build_garden()
        self.builder.build_pool()


class BookStore:

    def __init__(self, worker: Worker, deliveryman: Deliveryman) -> None:
        self._worker = worker or Worker()
        self._deliveryman = deliveryman or Deliveryman()

    def operation(self) -> str:
        results = []
        results.append("Book store initializes subsystems:")
        results.append(self._worker.work())
        results.append(self._deliveryman.deliver())
        results.append("Book store orders workers to perform the action:")
        results.append(self._worker.working())
        results.append(self._deliveryman.delivering())
        return "\n".join(results)


class Worker:

    def work(self) -> str:
        return "Worker: Ready to work!"

    def working(self) -> str:
        return "Worker: Sorting Books!"


class Deliveryman:

    def deliver(self) -> str:
        return "Deliveryman: Ready to delivery!"

    def delivering(self) -> str:
        return "Deliveryman: Delivering books!"


def client_code(facade: BookStore) -> None:
    print(facade.operation(), end="")


class Subject(ABC):

    @abstractmethod
    def attach(self, observer: Observer) -> None:
        pass

    @abstractmethod
    def detach(self, observer: Observer) -> None:
        pass

    @abstractmethod
    def notify(self) -> None:
        pass


class WWW(Subject):
    _state: int = None

    _observers: List[Observer] = []

    def attach(self, observer: Observer) -> None:
        self._observers.append(observer)

    def detach(self, observer: Observer) -> None:
        self._observers.remove(observer)

    def notify(self) -> None:
        print("Notifying observers")
        for observer in self._observers:
            observer.update(self)

    def some_business_logic(self) -> None:
        print("\nEverybody: Im doing something important.")
        self._state = random.randrange(-10, 10)
        print("pig: Hey i noticed something")
        self.notify()


class Observer(ABC):

    @abstractmethod
    def update(self, subject: Subject) -> None:
        pass


class ObserverA(Observer):
    def update(self, subject: Subject) -> None:
        if subject._state > 0:
            print("Observer1: reacted to the event")
        elif subject._state <= 0:
            print("Observer1: ...")


class ObserverB(Observer):
    def update(self, subject: Subject) -> None:
        if subject._state >= 5:
            print("Observer2: reacted to the event")
        elif subject._state < 5:
            print("Observer2:...")


class BuilderTest(unittest.TestCase):

    def test_bffp(self):
        director = Director()
        builder = Builder1()
        director.builder = builder
        director.build_full_featured_product()
        self.assertEqual(builder.product.parts, ['Floor', 'Walls', 'Roof', 'Garden', 'Pool'])

    def test_bmvp(self):
        director = Director()
        builder = Builder1()
        director.builder = builder
        director.build_minimal_viable_product()
        self.assertEqual(builder.product.parts, ['Floor', 'Walls', 'Roof'])


class Test(unittest.TestCase):

    @mock.patch('random.randrange')
    def test_poke(self, mock_randrange):
        mock_randrange.return_value = 3
        www = WWW()
        www_observer = ObserverA()
        www.attach(www_observer)
        www_catcher = ObserverB()
        www.attach(www_catcher)
        www.some_business_logic()
        self.assertEqual(www._state, 3)


if __name__ == '__main__':
    director = Director()
    builder = Builder1()
    director.builder = builder

    print("Standard basic product: ")
    director.build_minimal_viable_product()
    builder.product.list_parts()

    print("\n")

    print("Standard full featured product: ")
    director.build_full_featured_product()
    builder.product.list_parts()

    print("\n")

    print("Custom product: ")
    builder.build_floor()
    builder.build_walls()
    builder.build_pool()
    builder.product.list_parts()

    print("\n")

    worker = Worker()
    deliveryman = Deliveryman()
    bookstore = BookStore(worker, deliveryman)
    client_code(bookstore)

    print("\n")

    www = WWW()

    www_observer = ObserverA()
    www.attach(www_observer)

    www_catcher = ObserverB()
    www.attach(www_catcher)

    www.some_business_logic()

    www.detach(www_catcher)

    www.some_business_logic()

    print("\n")

    unittest.main()
