#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient').[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

## ClientService\.Request Method

| Overloads | |
| :--- | :--- |
| [Request\(HttpMethod, string\)](SHTCGClient.ClientService.Request.md#SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string) 'SHTCGClient\.ClientService\.Request\(System\.Net\.Http\.HttpMethod, string\)') | A helper method for sending a request to the API |
| [Request\(HttpMethod, string, object\)](SHTCGClient.ClientService.Request.md#SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object) 'SHTCGClient\.ClientService\.Request\(System\.Net\.Http\.HttpMethod, string, object\)') | A helper method for sending a request to the API |
| [Request&lt;T&gt;\(HttpMethod, string\)](SHTCGClient.ClientService.Request.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string) 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string\)') | A helper method for sending a request to the API |
| [Request&lt;T&gt;\(HttpMethod, string, object\)](SHTCGClient.ClientService.Request.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object) 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string, object\)') | A helper method for sending a request to the API |

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string)'></a>

## ClientService\.Request\(HttpMethod, string\) Method

A helper method for sending a request to the API

```csharp
public System.Threading.Tasks.Task<bool> Request(System.Net.Http.HttpMethod method, string url);
```
#### Parameters

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string).method'></a>

`method` [System\.Net\.Http\.HttpMethod](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod 'System\.Net\.Http\.HttpMethod')

Method to use

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The url, the API url /api/ is prepended already\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object)'></a>

## ClientService\.Request\(HttpMethod, string, object\) Method

A helper method for sending a request to the API

```csharp
public System.Threading.Tasks.Task<bool> Request(System.Net.Http.HttpMethod method, string url, object data);
```
#### Parameters

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object).method'></a>

`method` [System\.Net\.Http\.HttpMethod](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod 'System\.Net\.Http\.HttpMethod')

Method to use

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The url, the API url /api/ is prepended already\.

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object).data'></a>

`data` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The data do send

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string)'></a>

## ClientService\.Request\<T\>\(HttpMethod, string\) Method

A helper method for sending a request to the API

```csharp
public System.Threading.Tasks.Task<T?> Request<T>(System.Net.Http.HttpMethod method, string url);
```
#### Type parameters

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string).T'></a>

`T`
#### Parameters

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string).method'></a>

`method` [System\.Net\.Http\.HttpMethod](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod 'System\.Net\.Http\.HttpMethod')

Method to use

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The url, the API url /api/ is prepended already\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[T](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string).T 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The response object

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object)'></a>

## ClientService\.Request\<T\>\(HttpMethod, string, object\) Method

A helper method for sending a request to the API

```csharp
public System.Threading.Tasks.Task<T?> Request<T>(System.Net.Http.HttpMethod method, string url, object data);
```
#### Type parameters

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).T'></a>

`T`
#### Parameters

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).method'></a>

`method` [System\.Net\.Http\.HttpMethod](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod 'System\.Net\.Http\.HttpMethod')

Method to use

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The url, the API url /api/ is prepended already\.

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).data'></a>

`data` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The data do send

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[T](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).T 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string, object\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The response object