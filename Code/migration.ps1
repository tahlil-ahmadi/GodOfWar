param($task,$profile, $output)

if ($task -eq "d")
{
    $task = "migrate:down"
}
elseif ($task -eq "u")
{
    $task = "migrate"
}
else
{
    Write-Error "Please provide a task. use 'u' for migrate up and 'd' for migrate down"
    return
}


$arguments = @()
$arguments += '-configPath'
$arguments += 'ServiceHost\web.config' 
$arguments += '-connectionString'
$arguments += 'DBConnection'
$arguments += '--provider'
$arguments += 'sqlserver2012'
$arguments += '--assembly'
$arguments += '"UOM.DatabaseMigrations\bin\Debug\UOM.DatabaseMigrations.dll"'
$arguments += "--task"
$arguments +=  $task
$arguments += "--tag"

if ($profile){
    $arguments += $profile;
}
else{
    $arguments += "Production"
}

if ($output){
    $env:temp
    $env += "\migrate.sql"

    $arguments += "--output"
    $arguments += "--outputFilename"
    $arguments += $env;
    
}

&.\packages\FluentMigrator.1.6.2\tools\Migrate.exe $arguments


if ($output){
    Invoke-Item $env
}

