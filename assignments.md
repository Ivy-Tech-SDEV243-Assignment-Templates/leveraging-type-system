# Assignment Plan

## M1 — Build System Readiness Check

Done. Basic technology introduction check.

## M2 — Diagnostic Walkthrough

_Videos:_

Introducing the application: shows what the app does; basic demo.
Walkthrough.

_Starter Code Version:_

Vehicle driving application, intentionally buggy.

_Objectives:_

- Fix compile error
- Fix runtime error
- Fix logic error

_Checkpoints:_

- Guided: Compile time error fixed, committed (compile time error)
- Guided: Print debug logging commented out but committed; note that normally this would be taken out (runtime error)
- Guided: Screenshot showing debugger breakpoint (logic error)
- ... what to have students do on own for last one? Fix some bug.

## M3 — Guided Test Writing

_Videos:_

Walkthrough.

_Starter Code Version:_

Vehicle driving application with some tests already written. TripLog class tests.

_Objectives:_

- Run test suite
- Write test bodies

_Checkpoints:_

- Guided: Make a test fail intentionally - introduce a bug. Check in code
- Guided: Write a test body together, showing AAA pattern.
- Student: Complete first test given name / description / behavior.
- Student: Complete remaining tests given name / description / behavior.
- Guided: Show screenshot of passing tests; note that this is last checkpoint, so just explain that they'll need to do this after finishing the rest.

## M4 — Identifying What to Test

_Videos:_

Walkthrough.

_Starter Code Version:_

Vehicle driving application, same version as M3. Vehicle class tests.

No test suites or test project; students start from scratch. This assignment will cover vehicle class tests.

_Objectives:_

- Run test suite
- Determine appropriate tests

_Checkpoints:_

- Guided: Partially fill out "what to test" table / worksheet for Vehicle class
- Guided: Create test class and scaffold tests.
- Guided: Complete tests
- Student: fill out remaining table / worksheet; give them min number of tests to write
- Student: scaffold remaining tests
- Student: complete remaining tests

## M5 — Strengthening the Type System

_Videos:_

Introducing the application: shows what the app does; basic demo.
Walkthrough.

_Starter Code Version:_

"Bad" version of text transformer application.

Intentionally bad typing.

Existing tests must continue to pass.

_Objectives:_

- Replace magic values with enums to improve code clarity and safety
- Replace primitive types with stronger types
- Identify how exception types make error contracts explicit? (possibly remove this?)

_Checkpoints:_

- ... TODO: make bad version of app first ...
- Students will need to adjust tests as they go if method signatures change. Tests must pass.

## M6 — Externalize Configuration

_Videos:_

Walkthrough.

_Starter Code Version:_

"Bad" version of text transformer application.

Straightforward "move settings to a config" assignment. Existing config values will start off hardcoded, and be added for this assignment.

Existing tests must continue to pass.

_Objectives:_

- Distinguish between settings that belong in configuration versus values that belong in source code
- Use a configuration file to store and retrieve application settings
- Recognize the advantages or using strongly typed configuration bindings
- Recognize the importance of having a dedicated development environment that is separate from a production environment

_Checkpoints:_

- ... TODO: make bad version of app first ...

## M7 — Extract a Class into a Library

_Videos:_

Walkthrough.

_Starter Code Version:_

"Bad" version of text transformer application. Typing will still be bad, but we can still extract classes into a separate library.

Directly parallels a worked example in the book where a class is extracted into a library.

Not sure if we have a third party library included? I think one needs added, just for this assignment.

Existing tests must continue to pass. This will require modifying the package reference in the test project.

_Objectives:_

- Apply the Single Responsibility Principle at the project and class level
- Identify the role of internal and external dependencies within a software solution
- Use a package manager to install an external dependency
- Distinguish between Debug and Release build configurations and their appropriate use contexts
  - In other words, package / publish the application

_Checkpoints:_

- ... TODO: make bad version of app first ...
- Move text transformer classes into a separate library project.
- Modify package reference in test project

## M8 — Integration and End-to-End Tests

_Videos:_

Walkthrough.

_Starter Code Version:_

"Bad" version of text transformer application.

This will be a full walkthrough.

_Objectives:_

- Evaluate the tradeoffs between unit, integration, and end-to-end testing strategies
  - We're really just adding an integration test; not sure if we need to adjust what's in the course doc

I think we need to move the publish check here; last module is too packed:

- Distinguish between Debug and Release build configurations and their appropriate use contexts
  - In other words, package / publish the application

_Checkpoints:_

- Add an integration test with checkpoints at various points along the way.
