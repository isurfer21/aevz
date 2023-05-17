# aevz

`aevz` is a command-line tool that allows you to search and replace a string in a given file with another string or the content of another file. It is written in C# and runs on .NET Core.

## Features

- Fast and simple to use
- Supports plain text files of any size and encoding
- Supports loading replacement text from another file
- Supports displaying help and version information

## Installation

You can download the latest release of aevz from [here](https://github.com/isurfer21/aevz/releases). Alternatively, you can clone the repository and run it using the .NET Core SDK.

### Requirements

- .NET Core 5.0 or higher

### Running from source

To run aevz from source, follow these steps:

1. Clone the repository: `git clone https://github.com/isurfer21/aevz.git`
2. Change to the project directory: `cd aevz`
3. Run the tool: `dotnet run -- <arguments>`

## Usage

To use aevz, you need to provide three arguments: the search text, the replace text and the input/output file. The replace text can be either a string or the name of another file preceded by `@`. For example:

- To replace all occurrences of `foo` with `bar` in `test.txt`, run: `dotnet run -- foo bar test.txt`
- To replace all occurrences of `foo` with the content of `bar.txt` in `test.txt`, run: `dotnet run -- foo @ bar.txt test.txt`

You can also use the following options to display help or version information:

- To display help options, run: `dotnet run -- -h` or `dotnet run -- --help`
- To display version information, run: `dotnet run -- -v` or `dotnet run -- --version`

## License

aevz is licensed under the MIT License. See [LICENSE](https://github.com/isurfer21/aevz/blob/main/LICENSE) for more details.