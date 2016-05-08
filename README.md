#EmptyAspNetApplication


A basic Asp.net app, ready to be deployed.

It serves as a canvas to test webhosts or PAAS

with the most minimal Asp.net application possible.

##Installing

in a command line interface : 

    git clone git@github.com:mpm-projects/EmptyAspNetApp.git
    
You need a clr to build and run the application,see [these instructions][1] in order 
to install a clr on your machine (it supports Windows,Linux and MacOSX )

When the clr is installed, just type

    dnu restore
    dnu build
    dnx web
    
to run the application


[1]: https://docs.asp.net/en/latest/getting-started/index.html 