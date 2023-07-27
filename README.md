# Fuzzy API
## This project uses the fuzzysharp library to identify a phrase or word based on a list of options

Doc library FuzzySharp: https://github.com/JakeBayer/FuzzySharp

## API

- After downloading and running the project, it is possible to use the /api/ExtractOne-Score endpoint to perform an input analysis

```sh
{
  "menu": [
    "option1", "option2", "option3"
  ],
  "userInput": "inputTeste",
  "score": 60
}
```

- menu: "List with options"
- userInput: "Input to be analyzed"
- score: Number between 0 and 100, which will be used as the minimum reliability value between a menu option and the input

## Example

![image](https://github.com/GomesGuilherme07/FuzzyAPI/assets/23075005/0c5a5497-4486-4eab-a02d-805154b56ae7)

![image](https://github.com/GomesGuilherme07/FuzzyAPI/assets/23075005/ca336b2d-8f68-4a84-806c-ec3359476e10)




