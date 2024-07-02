namespace VerifyStrictJsonRepro;

public class UnitTest1
{
    [Fact]
    public Task Test1()
    {
        var jsonString =
            """
            {
              "productId": 78901,
              "productName": "Widget Pro",
              "category": "Gadgets",
              "price": 49.99,
              "inStock": true,
              "ratings": {
                "averageRating": 4.5,
                "reviews": [
                  {
                    "reviewId": 101,
                    "rating": 5,
                    "comment": "Excellent product!"
                  }
                ]
              },
              "relatedProducts": [
                {
                  "productId": 78902,
                  "productName": "Widget Mini",
                  "price": 29.99
                }
              ],
              "lastUpdated": "2024-07-02T14:30:00Z"
            }

            """;

        return VerifyJson(jsonString).UseStrictJson();
    }
}