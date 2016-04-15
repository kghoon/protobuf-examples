Protocol Buffer C# Example
===

현재 가장 최신 Release인 3.0.0-beta-2를 기준으로 protocol buffer를 사용하여 테스트 코드를 실행하는 방법을 설명한다.

IDL compiler
---

[protoc-3.0.0-beta-2-win32.zip][] 를 다운로드 받아 적절한 위치에 설치한다.

아래와 같은 방법으로 IDL을 compile하여 source code를 만들어 낼 수 있다.

```bash
$ protoc -I=./proto --csharp_out=./src ./proto/person.proto
```

참고로 이 테스트 코드에는 이 방법을 통해 생성 된 소스코드가 이미 포함되어 있다.

Runtime library 
---

### 빌드 하기

현재 3.0.0 버전은 미리 빌드되어 있는 `.DDL`파일이 존재하지 않으므로 직접 빌드해서 사용해야 한다.

1. 저장소에 Submodule로 등록되어 있는 `protobuf`를 Checkout한다.

 ```
 $ git submodule init
 $ git submodule update
 ```

1. Visual studio 2015 이상 버전에서 `protobuf\csharp\src\Google.Protobuf.sln` 파일을 연다.
1. 메뉴에서 `[Build]` - `[Build Solution]` 을 클릭하여 코드를 빌드한다.
1. `protobuf\csharp\src\Google.Protobuf\bin\Debug\Google.Protobuf.dll`이 생성되었는지 확인한다.

### 라이브러리 추가

테스트 코드를 빌드하고 실행하려면 위에서 빌드한 runtime 라이브러리인 `Google.Protobuf.dll`파일을 추가해야 한다.

1. Visual Studio에서 `csharp/ProtobufExample.sln`파일을 연다.
1. 메뉴에서 `[Project]` - `[Add Reference...]`를 클릭한다.
1. `Browse` 탭에서 `[Browse...]`버튼을 클릭하여 위에서 빌드한 `Google.Protobuf.dll`파일을 추가한다.


테스트 코드 실행
---

`Ctrl + F5` 를 눌러 테스트 코드를 실행한다. 아래와 같이 출력되면 성공한 것이다.

```
Hello,World!?
Server start
Client Start
Client accepted
Payload length: 142
Name:Jihoon, Id:1
Type:MOBILE, Number:010-1000-0001
Type:WORK, Number:02-2000-0002
=====
Name:Yongkyu, Id:2
Type:MOBILE, Number:010-1001-1001
Type:WORK, Number:02-2001-1002
=====
Response: Server recieved 142 bytes from client successfully!
Server end
Client End
Finished
계속하려면 아무 키나 누르십시오 . . .
```

[protoc-3.0.0-beta-2-win32.zip]:https://github.com/google/protobuf/releases/download/v3.0.0-beta-2/protoc-3.0.0-beta-2-win32.zip
