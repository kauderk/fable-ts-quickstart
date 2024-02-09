```
// setup https://fable.io/docs/getting-started/setup.html
femto --resolve

// types
npx -p typescript tsc src/Mars.ts --declaration --allowJs --emitDeclarationOnly --outDir types

// typescript to f sharp
npx @glutinum/cli ./types/Mars.d.ts --out-file ./fs2fable/Mars.fs

// dev
dotnet fable watch --lang typescript -o out --run npx vite
```