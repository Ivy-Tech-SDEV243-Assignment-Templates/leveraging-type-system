# Leveraging the Type System

## Template Repository

The template repository for this assignment is: [leveraging-type-system](https://github.com/Ivy-Tech-SDEV243-Assignment-Templates/leveraging-type-system).

**_Do not work directly from the starter template if using CodeSpaces! make sure to first click "Use this template" and create a repository in your personal account, then create the CodeSpace from your repository page._**

## Introduction

The purpose of this assignment is to learn how to leverage the type system to improve the clarity and safety of our code.

This assignment has a video walkthrough to accompany the written instructions. Some checkpoints may require you to complete work on your own.

Be sure to match any provided video output exactly, including:

- filenames
- code
- comments
- commit messages
- screenshots

## Learning Goals

- Refactor existing code to demonstrate how unit tests protect against regressions.
- Replace magic strings with enums to improve code clarity and safety.
- Use an interface to define a class's public contract.

## Checkpoints

### Check1: Refactoring EmojiTransform to improve performance

The `EmojiTransform` class is currently implemented using a loop. We can see from the tests that it satisfies the requiremements, but it is not the most performant way to implement the class. Right now it creates a new string for each replacement, which is not efficient.

We will refactor the class to use a regex to improve performance. The existing tests will confirm that the functionality is preserved.

_Deliverables:_

- `EmojiTransform.cs`: Modified to use a regex.
- Commit with message "check1".

### Check2: Refactoring CaseTransform to use an enum

The `CaseTransform` class is currently implemented using magic strings. This is a brittle solution; there is nothing preventing a developer from passing in an invalid string.

We will refactor the class to use an enum to improve safety. The existing tests will confirm that the functionality is preserved.

**On your own:**

We will do two of the transform options together (None and Lower). You must:

- Implement the remaining two (Upper and Title)
- Modify tests to account for the new options.

_Deliverables:_

- `CaseOption.cs`: Added new enum definition.
- `CaseTransform.cs`: Modified to use the new enum.
- `CaseTransformTests.cs`: Modified to use the enum (fixed the tests after refactor).
- Commit with message "check2".

### Check3: Replace manual transform pipeline with dedicated TransformPipeline class

We are assuming that in this program the caller is usually running the same series of transforms on multiple files. The `Program.cs` file currently allows the consumer (the developer using the pipeline classes) to create several transform instances and apply them in sequence. The caller, however, must call the transform methods in the correct order for each file.

We will create a `TransformPipeline` class that accepts a list of transforms and applies them in order. To do this, we will use an interface to establish what methods must exist on the class.

**On your own:**

We will do two of the transform options together (Case and Emoji). You must:

- Implement the remaining (Whitespace)
- Add the original transform to the pipeline in `Program.cs`

_Deliverables:_

- `ITransform.cs`: Added new interface definition.
- `CaseTransform.cs`, `EmojiTransform.cs`, `WhitespaceTransform.cs`: Modified to implement the interface.
- `TransformPipeline.cs`: Added new class definition that implements the interface.
- `Program.cs`: Modified to use the new class for the three transforms.
- Commit with message "check3".

## Submission

After completing all checkpoints:

- Confirm that the checkpoints exist in the remote repository
- Check the rubric to see if all requirements were met
- Submit the URL to the root of your GitHub Repository, `https://github.com/[your-username]]/leveraging-type-system`
