# Blazor.Tailwind.Templates

[![Nuget version](https://img.shields.io/nuget/v/Blazor.Tailwind.Templates?color=ff4081&label=nuget%20version&logo=nuget&style=flat-square)](https://www.nuget.org/packages/Blazor.Tailwind.Templates/)
[![Nuget downloads](https://img.shields.io/nuget/dt/Blazor.Tailwind.Templates?color=ff4081&label=nuget%20downloads&logo=nuget&style=flat-square)](https://www.nuget.org/packages/Blazor.Tailwind.Templates/)

## Getting Started

### Installation

```sh
dotnet new install Blazor.Tailwind.Templates
```

### Usage

You can specify different interactivity options using the `--interactivity` option. The available options are `none`, `server`, `auto`, and `wasm`.

#### Interactivity: none

```sh
dotnet new blazortailwind --interactivity none -o MyApplication
```

#### Interactivity: server

```sh
dotnet new blazortailwind --interactivity server -o MyApplication
```

#### Interactivity: auto

```sh
dotnet new blazortailwind --interactivity auto -o MyApplication
```

#### Interactivity: wasm

```sh
dotnet new blazortailwind --interactivity wasm -o MyApplication
```

### Usage with Framework

To specify the framework, use the `--framework` option. You can use `net8.0`, `net9.0`, or both `net8.0;net9.0` (*Note that this is only applicable if the interactivity is `wasm` for now*).

```sh
dotnet new blazortailwind --interactivity wasm --framework net8.0 -o MyApplication
```

```sh
dotnet new blazortailwind --interactivity wasm --framework net9.0 -o MyApplication
```

```sh
dotnet new blazortailwind --interactivity wasm --framework "net8.0;net9.0" -o MyApplication
```

### Sample Site with Theme

You can view a sample site [here](https://jjosh102.github.io/Blazor.Tailwind.Templates/).
