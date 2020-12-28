from django.shortcuts import render

# Create your views here.


def index(request):
    return render(request, 'main/index.html')


def sort(request):

    if request.GET.get("tsort", "") == "737":
        return render(request, 'main/sort.html', {'name': '737'})
    elif request.GET.get("tsort", "") == "757":
        return render(request, 'main/sort.html', {'name': '757'})


