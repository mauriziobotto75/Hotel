# Random Joke Generator - WPF Application

A modern WPF application that fetches random jokes from an external API using C#, MVVM pattern, and async/await.

## Features

✨ **Core Features:**
- 🎲 Get random jokes from API
- 📂 Filter jokes by category (General, Programming, Knock-Knock)
- 📊 Track total jokes loaded
- ⏳ Async loading with user feedback
- ❌ Error handling with user-friendly messages
- 🎨 Modern, gradient UI with smooth interactions

## Technologies Used

- **Framework**: .NET 6.0 / WPF
- **Pattern**: MVVM (Model-View-ViewModel)
- **API**: [API Ninjas - Jokes](https://api-ninjas.com/api/jokes)
- **JSON**: Newtonsoft.Json (NuGet)
- **Async**: C# async/await for non-blocking operations

## Project Structure

```
JokeGenerator/
├── Services/
│   └── JokeService.cs           # API integration
├── ViewModels/
│   ├── JokeViewModel.cs         # MVVM logic
│   └── RelayCommand.cs          # Command binding
├── Converters/
│   └── StringToVisibilityConverter.cs
├── MainWindow.xaml              # UI
├── MainWindow.xaml.cs           # Code-behind
├── App.xaml                     # App configuration
└── JokeGenerator.csproj         # Project file
```

## Setup Instructions

### 1. Get API Key
- Visit [API Ninjas](https://api-ninjas.com/)
- Sign up for a free account
- Get your API key from the dashboard

### 2. Configure API Key
Edit `Services/JokeService.cs` and replace:
```csharp
private const string JokeApiKey = "YOUR_API_KEY_HERE";
```

### 3. Install Dependencies
```bash
dotnet add package Newtonsoft.Json
```

### 4. Build and Run
```bash
dotnet build
dotnet run
```

## Usage

### Get Random Joke
- Click **"Get Random Joke"** button to fetch a random joke

### Get Category Joke
- Select a category from the dropdown (General, Programming, Knock-Knock)
- Click **"Get Category Joke"** to fetch a joke from that category

### Clear
- Click **"Clear"** to reset the joke counter and message

## API Endpoints

### Get Random Joke
```
GET https://api.api-ninjas.com/v1/jokes
Headers: X-Api-Key: YOUR_API_KEY
```

### Get Joke by Category
```
GET https://api.api-ninjas.com/v1/jokes?category={category}
Headers: X-Api-Key: YOUR_API_KEY
```

## Response Format

```json
[
  {
    "joke": "Why did the programmer quit his job? Because he didn't get arrays.",
    "category": "programming"
  }
]
```

## Code Examples

### Fetch Random Joke
```csharp
var jokeService = new JokeService();
var joke = await jokeService.GetRandomJokeAsync();
Console.WriteLine(joke.Text);
```

### Fetch Joke by Category
```csharp
var joke = await jokeService.GetJokeByCategoryAsync("programming");
Console.WriteLine(joke.Text);
```

## Error Handling

- Network errors are caught and displayed to user
- Invalid API responses are handled gracefully
- Loading state prevents multiple simultaneous requests

## UI Features

### Visual Design
- 🎨 Gradient background (Purple theme)
- 🔘 Smooth button hover effects
- ⚠️ Error message display with red styling
- 🔄 Loading indicator during API calls
- 📱 Responsive layout

### Components
- Text input for joke display (scrollable)
- Category dropdown selector
- Three action buttons (Random, Category, Clear)
- Joke counter display
- Error message panel
- Loading indicator

## MVVM Architecture

### JokeViewModel
- `CurrentJoke`: The displayed joke text
- `JokeCategory`: Selected category
- `IsLoading`: Loading state
- `ErrorMessage`: Error messages
- `JokeCount`: Total jokes loaded

### Commands
- `GetJokeCommand`: Fetch random joke
- `GetJokeByCategoryCommand`: Fetch by category
- `ClearCommand`: Reset application state

## Performance Considerations

- ✅ Async/await for non-blocking UI
- ✅ HttpClient reuse for connection pooling
- ✅ Single API call per request
- ✅ Lazy loading with indicator
- ✅ Error recovery without crashing

## Future Enhancements

- 📝 Add favorite jokes list
- 💾 Save jokes to file
- 🔍 Search jokes by keyword
- 📊 Show joke statistics
- 🌐 Add more API sources
- 🎤 Text-to-speech functionality
- 📋 Copy to clipboard button
- 🌙 Dark mode toggle

## Troubleshooting

### "Error: Invalid API Key"
- Verify your API key is correct
- Check API Ninjas website for key validity
- Ensure key has not expired

### "Error: No joke found"
- The selected category might have no jokes available
- Try a different category
- Check internet connection

### "Connection timeout"
- Verify internet connection
- Check if API Ninjas is down
- Try again in a few seconds

## License

MIT License - Feel free to use for personal and commercial projects

## Author

Maurizio Botto

## Support

For issues or questions:
- Check [API Ninjas Documentation](https://api-ninjas.com/api/jokes)
- Visit [GitHub Issues](https://github.com/mauriziobotto75/Hotel/issues)
