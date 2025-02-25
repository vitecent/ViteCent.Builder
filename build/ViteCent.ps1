$root = "E:/Server/ViteCent/"

cd $root
docker-compose up -d

$paths = @("/src/ViteCent.Service/ViteCent.Service.Service/bin/Debug/net9.0/", 
"src/ViteCent.Files/ViteCent.Files.Service/bin/Debug/net9.0/",
"src/ViteCent.Gateway/ViteCent.Gateway.Service/bin/Debug/net9.0/",
"src/ViteCent.Job/ViteCent.Job.Service/bin/Debug/net9.0/"
)
 
foreach ($element in $paths) {
    $path = Join-Path -Path $root -ChildPath $element
	cd $path
	docker-compose up -d
}

cd $root
docker-compose -f dapr.yml up -d
