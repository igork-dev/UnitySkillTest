using UnityEngine;
using System.Collections;

public class EditorCreator : MonoBehaviour {
	
	public Vertex InstantiateVertex( Vector3 position ) {
		GameObject vertexGO = Instantiate( Resources.Load("Vertex"), position, Quaternion.identity ) as GameObject;
		return vertexGO.GetComponent<Vertex>();
	}
	
	public Line InstantiateLine( Vertex vertexA, Vertex vertexB ) {
		
		GameObject lineGO = Instantiate( Resources.Load("Line"), Vector3.zero, Quaternion.identity ) as GameObject;
		lineGO.renderer.enabled = false;
		Line line = lineGO.GetComponent<Line>();
		
		line.Initialize( vertexA, vertexB );
		lineGO.renderer.enabled = true;
		
		return line;
	}
}
