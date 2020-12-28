from behave import *
from main import *

use_step_matcher("re")


@given("Book store")
def step_impl(context):
    context.worker = Worker()
    context.deliveryman = Deliveryman()


@when("Book store init")
def step_impl(context):
    context.bookstore = BookStore(context.worker, context.deliveryman)


@then("worker and deliver getting ready")
def step_impl(context):
    assert context.worker.work() == "Worker: Ready to work!"
    assert context.deliveryman.deliver() == "Deliveryman: Ready to delivery!"


@when("Book store start working")
def step_impl(context):
    context.worker.working()
    context.deliveryman.delivering()


@then("worker and deliver are working")
def step_impl(context):
    assert context.worker.working() == "Worker: Sorting Books!"
    assert context.deliveryman.delivering() == "Deliveryman: Delivering books!"
