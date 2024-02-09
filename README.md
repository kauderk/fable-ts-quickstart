```
// setup https://fable.io/docs/getting-started/setup.html
femto --resolve

// types
npx -p typescript tsc src/Mars.ts --declaration --allowJs --emitDeclarationOnly 

// typescript to f sharp
ts2fable ./types/Mars.d.ts --out-file ./fs2fable/Mars.fs
// be aware this generates "*", "Mars" but it should be "mars","./Mars.ts" - I'm sure I'm doing something wrong 

// dev
dotnet fable watch --lang typescript -o out --run npx vite
// sometimes you might need to restart vscode to get the intellisense working
```