/*
This program doesn't accept user input. Everything comes from the configuration
file. It always builds a pipeline with the three transforms in the provided
order. The main focus of the solution is how everything is rigged together: the
CLI application represents a client using the library.

The idea is that the consumer instantiates the pipeline with immutable
configuration for the transforms, then runs a series of documents through the
pipeline. In reality, we will probably only run one document through the
pipeline.
*/

// Constants
string textFilePath1 = "samples/input1.txt";
string textFilePath2 = "samples/input2.txt";
string emojiMapPath = "samples/emoji-map.txt";
string outputFilePath1 = "samples/output1.txt";
string outputFilePath2 = "samples/output2.txt";

string input = File.ReadAllText(textFilePath1);
Dictionary<string, string> emojiMap = EmojiFileParser.Parse(emojiMapPath);

var caseTransform = new CaseTransform("lower");
var emojiTransform = new EmojiTransform(emojiMap);
var whitespaceTransform = new WhitespaceTransform(spacesAfterSentenceEnd: 2);

// Transform first file
string output = caseTransform.Transform(input);
output = emojiTransform.Transform(output);
output = whitespaceTransform.Transform(output);
File.WriteAllText(outputFilePath1, output);

// Transform second file
input = File.ReadAllText(textFilePath2);
output = caseTransform.Transform(input);
output = emojiTransform.Transform(output);
output = whitespaceTransform.Transform(output);
File.WriteAllText(outputFilePath2, output);

// TODO: make a TransformPipeline class that accepts a list of transforms and applies them in order
