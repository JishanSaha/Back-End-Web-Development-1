# Files for HTTP-5125
## Course: Back-End Web Development 1
### Course Code: HTTP 5125

### Academic Year: 2024-2025

This course introduces students to server-side web development using the C# programming language. Students will learn to implement techniques for building data-driven websites that utilize various external data sources.

## Helpful Links
- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)

## Visual Reference
![C# Web Development Overview](backend.png)

> **Important Note:** This repository contains key files and resources to aid your learning in back-end development. Understanding databases and APIs will significantly improve your grasp of data-driven techniques.

## Sample Code

```csharp
[Route("api/[controller]")]
[ApiController]
public class J1Controller : ControllerBase
{
    /// <summary>
    /// Computes the total score based on packages delivered and collisions.
    /// </summary>
    /// <param name="collision">The number of collisions.</param>
    /// <param name="delivered">The number of deliveries.</param>
    /// <returns>The total score calculated.</returns>
    /// <example>
    ///  POST: api/J1/Delivedroid
    ///  Headers: Content-Type: application/x-www-form-urlencoded
    ///  Post data: Collisions=2&Deliveries=5
    ///  ->730
    ///  POST: api/J1/Delivedroid
    ///  Headers: Content-Type: application/x-www-form-urlencoded
    ///  Post data: Collisions=10&Deliveries=0
    ///  ->-100
    ///  POST: api/J1/Delivedroid
    ///  Headers: Content-Type: application/x-www-form-urlencoded
    ///  Post data: Collisions=3&Deliveries=2
    ///  ->70
    /// </example>
    [HttpPost(template: "Delivedroid")]
    [Consumes("application/x-www-form-urlencoded")]
    public int Deliverdroid([FromForm] int collision, [FromForm] int delivered)
    {
        int total = (delivered * 50) + (collision * -10);
        if (delivered > collision)
        {
            total += 500;
        }
        return total;
    }
}
