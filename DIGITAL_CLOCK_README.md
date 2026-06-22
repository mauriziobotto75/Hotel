# Digital Clock - Multiple Time Zones 🕐

A beautiful WPF application that displays the current time in different time zones around the world with real-time updates.

## ✨ Features

### Core Functionality
- 🕐 **Display Multiple Time Zones** - Show times from any location worldwide
- 🌍 **All System Time Zones** - Access to all available Windows time zones
- ⏰ **Real-Time Updates** - Refreshes every second automatically
- 🔄 **Format Toggle** - Switch between 24-hour and 12-hour formats
- 📍 **UTC Offset Display** - See the difference from UTC
- ➕ **Add Time Zones** - Dynamically add clocks
- ❌ **Remove Time Zones** - Remove specific clocks
- 🔄 **Reset Function** - Restore default time zones
- 🗑️ **Clear All** - Remove all clocks

### UI Features
- 🎨 **Dark Theme** - Modern, professional interface
- 📱 **Responsive Design** - Works with many time zones
- 🎯 **Intuitive Controls** - Easy-to-use management panel
- 🖥️ **Smooth Animations** - Button hover effects
- 📊 **Live Counter** - Shows active clock count

## 🛠️ Technologies

- **Framework**: .NET 6.0 WPF
- **Pattern**: MVVM (Model-View-ViewModel)
- **Language**: C#
- **Threading**: System.Timers.Timer
- **Time API**: System.TimeZoneInfo

## 📂 Project Structure

```
DigitalClock/
├── Models/
│   └── ClockModel.cs              # Time zone data model
├── Services/
│   ├── TimeZoneService.cs         # Time zone management
│   └── CollectionExtensions.cs    # Utility extensions
├── ViewModels/
│   ├── DigitalClockViewModel.cs   # MVVM logic
│   └── RelayCommand.cs            # Command binding
├── MainWindow.xaml                # UI layout
├── MainWindow.xaml.cs             # Code-behind
├── App.xaml                       # Application config
└── DigitalClock.csproj            # Project file
```

## 🚀 Quick Start

### Build and Run
```bash
cd DigitalClock
dotnet build
dotnet run
```

### Add a Time Zone
1. Select a time zone from the dropdown
2. Click "➕ Add Time Zone" button
3. New clock appears instantly

### Change Format
- Toggle "24-Hour Format" checkbox in header
- All clocks update in real-time

### Manage Clocks
- **Remove Last**: Removes the most recent clock
- **Reset to Default**: Restores original time zones
- **Clear All**: Removes all clocks

## 🎨 UI Layout

```
┌────────────────────────────────────────────┐
│ 🕐 Digital Clock - Multiple Time Zones    │
│ Local: 14:30:45  Sunday, June 22, 2026    │
├────────────────────────────────────────────┤
│                                ┌──────────┐│
│ ┌──────┐ ┌──────┐ ┌──────┐  │ ⚙️ Add   ││
│ │14:30 │ │08:30 │ │20:30 │  │ [Select] ││
│ │ EDT  │ │ CDT  │ │ IST  │  │ +Add ➕  ││
│ │ Sun  │ │ Sun  │ │ Sun  │  │ -Remove  ││
│ │UTC-4 │ │UTC-5 │ │UTC+5.5  │ 🔄 Reset ││
│ └──────┘ └──────┘ └──────┘  │ 🗑️ Clear ││
│                                └──────────┘│
├────────────────────────────────────────────┤
│ ✨ Select time zones to compare globally  │
└────────────────────────────────────────────┘
```

## 🎯 Default Time Zones

Pre-configured popular zones:
- Eastern Standard Time (EST/EDT)
- Central Standard Time (CST/CDT)
- Mountain Standard Time (MST/MDT)
- Pacific Standard Time (PST/PDT)
- GMT Standard Time (GMT)
- Central Europe Standard Time (CET/CEST)
- India Standard Time (IST)
- China Standard Time (CST)
- Tokyo Standard Time (JST)
- AUS Eastern Standard Time (AEST/AEDT)
- UTC (Coordinated Universal Time)

## 💻 Code Examples

### Get Time in a Specific Zone
```csharp
var service = new TimeZoneService();
var nyTime = service.GetTimeInTimeZone(
    TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")
);
Console.WriteLine(nyTime.ToString("HH:mm:ss"));
```

### Add Multiple Zones Programmatically
```csharp
var vm = new DigitalClockViewModel();
var estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
vm.SelectedTimeZone = estZone;
vm.AddTimeZoneCommand.Execute(null);
```

### Get All Available Time Zones
```csharp
var allZones = TimeZoneInfo.GetSystemTimeZones();
foreach (var tz in allZones)
{
    Console.WriteLine($"{tz.DisplayName} ({tz.BaseUtcOffset})");
}
```

## 🎨 Color Scheme

| Element | Color | Hex |
|---------|-------|-----|
| Background | Dark Gray | #1a1a1a |
| Header | Deep Blue | #0d47a1 |
| Clock Bg | Slate | #263238 |
| Primary | Cyan | #00BCD4 |
| Accent | Yellow | #FFD54F |
| Success | Green | #4CAF50 |
| Warning | Orange | #FF9800 |
| Error | Red | #f44336 |

## 🔧 Architecture

### TimeZoneService
- Manages all time zone operations
- Provides real-time updates via timer
- Handles timezone conversion
- Loads system time zones

### DigitalClockViewModel
- Manages UI state and logic
- Implements MVVM commands
- Handles clock collection
- Coordinates with TimeZoneService

### ClockModel
- Represents a single time zone
- Stores current time
- Provides formatting methods
- Updates time values

## ⚡ Performance

- ✅ Efficient timer-based updates (1 second)
- ✅ ObservableCollection for live updates
- ✅ No UI blocking operations
- ✅ Minimal memory footprint
- ✅ Smooth scrolling support

## 🌟 Advanced Features

### Real-Time Synchronization
- All clocks update simultaneously
- Timer fires every second
- Event-driven architecture

### Dynamic Time Zone Switching
- Add zones on-the-fly
- Remove without restart
- Reset to defaults instantly

### Format Flexibility
- 24-hour format (HH:mm:ss)
- 12-hour format (hh:mm:ss tt)
- Automatic AM/PM display

## 🔮 Future Enhancements

- 🌙 Dark/Light theme toggle
- 💾 Save favorite zones
- 📊 Time zone comparison matrix
- 🔔 Alarm functionality
- 🗺️ World map integration
- 📱 Fullscreen mode
- 🎯 Pin favorite zones
- 🌐 NTP time sync
- 📈 Time difference calculator
- 🔊 Notifications

## 📋 System Requirements

- Windows 10 or later
- .NET 6.0 Runtime
- 100 MB available space
- Standard system time zone database

## 🐛 Troubleshooting

### Clocks not updating
- Ensure window is not minimized
- Try Reset to Defaults
- Restart the application

### Time zone not showing
- Verify timezone exists on system
- Check Windows Time Zone settings
- Select from dropdown list

### Performance issues
- Close unnecessary applications
- Reduce number of active clocks
- Restart application

## 📄 License

MIT License - Open source and free to use

## 👤 Author

Maurizio Botto

## 🔗 Repository

GitHub: https://github.com/mauriziobotto75/Hotel

---

**Enjoy comparing times around the world! 🌍🕐**
