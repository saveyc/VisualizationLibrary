/**************************************************************************************/
/*                                                                                    */
/*  Copyright (c) 2005-2011, Michele Bosi.                                            */
/*  All rights reserved.                                                              */
/*                                                                                    */
/*  This file is part of Visualization Library                                        */
/*  http://visualizationlibrary.org                                                   */
/*                                                                                    */
/*  Released under the OSI approved Simplified BSD License                            */
/*  http://www.opensource.org/licenses/bsd-license.php                                */
/*                                                                                    */
/**************************************************************************************/

#extension GL_ARB_texture_array: enable
#extension GL_EXT_gpu_shader4: enable
uniform sampler2DArray sampler0;
void main(void)
{
	gl_FragColor = texture2DArray(sampler0, gl_TexCoord[0].xyz );
}