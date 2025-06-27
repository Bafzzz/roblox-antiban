
# KC Lite Anti-Ban (Level 1–2)

A lightweight, effective anti-ban system for your executor, designed to provide basic protection without overwhelming power. Perfect for users who want solid defense while staying humble.

---

## Features

- Creates a random mutex to prevent multi-instance detection  
- Randomizes the window title for simple obfuscation  
- Hides the executor from the taskbar  
- Sends a silent usage log ping to a customizable server for usage tracking  
- Console output mimics a terminal status panel for that “elite hacker” vibe  

---

## Usage

1. Add the `KCLiteAntiBan.cs` file to your project.

2. In your main executor form (e.g., `Form1`), call the initializer in the constructor:

```csharp
public Form1()
{
    InitializeComponent();
    KCLiteAntiBan.Initialize(this);
}
