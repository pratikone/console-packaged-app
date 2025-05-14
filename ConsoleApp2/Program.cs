// See https://aka.ms/new-console-template for more information
using Microsoft.Windows.AI;
using Microsoft.Windows.AI.Generative;
Console.WriteLine("Hello, World!");
Console.ReadLine();
// Initialize the AI model
if (LanguageModel.GetReadyState() == AIFeatureReadyState.EnsureNeeded)
{
   await LanguageModel.EnsureReadyAsync();
}
LanguageModel model = await LanguageModel.CreateAsync();

LanguageModelResponseResult response = await model.GenerateResponseAsync("What is the capital of France?");
Console.WriteLine(response.Text);


