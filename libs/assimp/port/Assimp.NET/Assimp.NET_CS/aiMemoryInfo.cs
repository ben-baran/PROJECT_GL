/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiMemoryInfo : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMemoryInfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiMemoryInfo obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMemoryInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiMemoryInfo(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiMemoryInfo() : this(AssimpPINVOKE.new_aiMemoryInfo(), true) {
  }

  public uint textures {
    set {
      AssimpPINVOKE.aiMemoryInfo_textures_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMemoryInfo_textures_get(swigCPtr);
      return ret;
    } 
  }

  public uint materials {
    set {
      AssimpPINVOKE.aiMemoryInfo_materials_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMemoryInfo_materials_get(swigCPtr);
      return ret;
    } 
  }

  public uint meshes {
    set {
      AssimpPINVOKE.aiMemoryInfo_meshes_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMemoryInfo_meshes_get(swigCPtr);
      return ret;
    } 
  }

  public uint nodes {
    set {
      AssimpPINVOKE.aiMemoryInfo_nodes_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMemoryInfo_nodes_get(swigCPtr);
      return ret;
    } 
  }

  public uint animations {
    set {
      AssimpPINVOKE.aiMemoryInfo_animations_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMemoryInfo_animations_get(swigCPtr);
      return ret;
    } 
  }

  public uint cameras {
    set {
      AssimpPINVOKE.aiMemoryInfo_cameras_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMemoryInfo_cameras_get(swigCPtr);
      return ret;
    } 
  }

  public uint lights {
    set {
      AssimpPINVOKE.aiMemoryInfo_lights_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMemoryInfo_lights_get(swigCPtr);
      return ret;
    } 
  }

  public uint total {
    set {
      AssimpPINVOKE.aiMemoryInfo_total_set(swigCPtr, value);
    } 
    get {
      uint ret = AssimpPINVOKE.aiMemoryInfo_total_get(swigCPtr);
      return ret;
    } 
  }

}
