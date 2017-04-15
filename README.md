# Publish Subscribe middleware

This middleware implements the publish/subscribe pattern by adding these methods

1. A publish method 



----
# How to build it 
Correct build command would be:
~~~~  
nuget pack -properties Configuration=Release -symbols
~~~~

Note that this command does not work as per 15 April 2017 - documented dotnetcore issue
https://github.com/NuGet/Home/issues/4808

use workaround instead: 
~~~~
dotnet pack
~~~~

# How to ship it
1. make an account on myget.org so that you get an access token while registering
use that token with the push command: 

~~~~
nuget push PublishSubscribeMiddleware.1.0.0.nupkg <your_token_here> -Source https://www.myget.org/F/greenelephantio/api/v2/package 
~~~~

# How to use

add a new nuget package source with url 
https://www.myget.org/F/greenelephantio/api/v2

after installing the package, do
~~~~
using GreenElephantIO.Middleware;
~~~~
...and in the Configure method of Startup.cs, add
~~~~
app.UsePublishSubscribeFunctionality();
~~~~

...thats all. 