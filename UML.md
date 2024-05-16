```mermaid
classDiagram
Animal  <|-- Dog
class Dog{
+Speak() string
}
class Animal{
+Name string
+Move() void
+Speak() string
}
class Human{
+Name string
+Animals List<Animal>
}
Animal  <|-- Cat
class Cat{
+Speak() string
}
```
