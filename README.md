# Insphere Technical Assessment

## Quickstart
1. Clone repo
2. Open Insphere.API.sln and run solution
3. Open Insphere.Reader.sln and run solution
4. Open Insphere.Frontend.sln and run solution

## Frontend WPF Application
- Features a table of data including 3D points and a 3d viewer using Felix WPF Toolkit (based on DirectX 11)
- Uses Unity for dependency injection
- Modelled in an MVVM pattern for ease of access (3D renderer viewport is the only thing that breaks this)
- Click and drag centre divider to move it
- Click and drag the 3d window to rotate around the object path
- If requests fail there is a retry button that is hidden until an error occurs

## API
- Simple C# ASP .Net Core Web API with dependency injection and a gRPC client that communicates with the Reader service

## Reader Service
- Single responsibility of pulling CSV data, processing it and returning it
- gRPC service for communication
- Contains tests for extension methods and CSV reading
- Uses parallel foreach to calculate 3D centre point for data to allow the frontend's camera to focus on that point

## Comments
- All 3 solutions use the Global project, allowing shared protobuf files and making code generation easier
- I avoided writing tests for the API as it's not doing anything besides error handling for http requests, although if any custom functionality was added I would have done
- The test coverage for the Reader service is good but could be improved potentially by including all possible individual null reference for each field, however I chose to avoid doing this as I believe the testing provides a decent amount of coverage without going too overboard
- I think given more time an improvement could also be using protobuf generated classes for communication with the frontend, however this wasn't in the spec so I avoided looking too much into this
