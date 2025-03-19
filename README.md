# TP1 - Simple Drawing Application

This project is a simple drawing application built with Windows Forms. It allows users to draw lines, rectangles, and ellipses on a canvas. Users can also change the color and thickness of the drawing tools, save their drawings to a text file, and open existing drawings from a text file.

## Features

*   **Drawing Tools:**
    *   Line
    *   Rectangle
    *   Ellipse
*   **Color Selection:** Choose a drawing color using a color dialog.
*   **Thickness Adjustment:** Modify the thickness of the drawing pen.
*   **Save/Load:** Save drawings to a text file and load them later.
*   **Context Menu:** Right-click on the canvas for quick access to color, thickness, and clearing options.

## How to Use

1.  **Choose a Drawing Tool:** Select a tool (Line, Rectangle, Ellipse) from the "Outils" menu or the bottom toolbar.
2.  **Select a Color:** Click the black square in the bottom toolbar to open the color dialog and choose your desired color.
3.  **Adjust Thickness:**
    *   Use the "Épaisseur du trait..." option in the "Outils" menu to open a dialog for precise thickness control.
    *   Use the "+" and "-" buttons in the context menu (right-click on the canvas) to quickly adjust thickness.
    *   The current thickness is displayed in the bottom toolbar.
4.  **Draw:** Click and drag on the canvas to draw the selected shape.
5.  **Save:** Go to "Fichier" -> "Enregistrer..." to save your drawing.
6.  **Open:** Go to "Fichier" -> "Ouvrir..." to open an existing drawing.
7. **Clear:** Right-click on canvas and select "Effacer Tout".

## Project Structure

*   **Form1:** The main form of the application, handling user interaction and drawing.
*   **Tableau:** A class responsible for managing the list of shapes and drawing them on the canvas.
*   **IForme:** An interface defining the common methods for all shapes.
*   **FormeAbstraite:** An abstract class implementing `IForme` and providing common properties and methods for concrete shapes.
*   **Ligne, Rectangle, Ellipse:** Concrete shape classes inheriting from `FormeAbstraite`.
*   **TypeForme:** An enum representing the different types of shapes.
*   **FluxEcriture:** A class to handle writing shape data to a file.
* **FormulaireEpaisseur:** A form to change the thickness.

## Dependencies

*   .NET 8.0 Windows Desktop

## Build

The project can be built using Visual Studio. Open the `TP1.sln` file and build the solution.
