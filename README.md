# dice cli
## Made in c# btw

# How to Build/Use  
### Prerequisites
1. git  
2. .NET sdk  
3. I dont know if this works on linux so ill test this later cause my laptop isnt working  
clone this repo w/ ``git clone https://github.com/lukehtml/dice-cli-2.git``  
cd into the directory w/ ``cd dice-cli-2``  
build w/ ``dotnet publish -c Release -r win-x64 -p:PublishSingleFile=true`` for windows,  
 ``dotnet publish -c Release -r linux-x64 -p:PublishSingleFile=true`` for linux,  
 ``dotnet publish -c Release -r osx-x64 -p:PublishSingleFile=true``  for intel macs  
and ``dotnet publish -c Release -r osx-arm64 -p:PublishSingleFile=true`` for sillicon macs/ m1 to m3
