from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('sort', views.sort),
]