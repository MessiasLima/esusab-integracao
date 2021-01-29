/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
package br.gov.saude.esusab.ras.atendodonto;

import org.apache.thrift.scheme.IScheme;
import org.apache.thrift.scheme.SchemeFactory;
import org.apache.thrift.scheme.StandardScheme;

import org.apache.thrift.scheme.TupleScheme;
import org.apache.thrift.protocol.TTupleProtocol;
import org.apache.thrift.protocol.TProtocolException;
import org.apache.thrift.EncodingUtils;
import org.apache.thrift.TException;
import org.apache.thrift.async.AsyncMethodCallback;
import org.apache.thrift.server.AbstractNonblockingServer.*;
import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.util.HashMap;
import java.util.EnumMap;
import java.util.Set;
import java.util.HashSet;
import java.util.EnumSet;
import java.util.Collections;
import java.util.BitSet;
import java.nio.ByteBuffer;
import java.util.Arrays;
import javax.annotation.Generated;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

@SuppressWarnings({"cast", "rawtypes", "serial", "unchecked"})
@Generated(value = "Autogenerated by Thrift Compiler (0.9.3)", date = "2021-01-29")
public class ProcedimentoQuantidadeThrift implements org.apache.thrift.TBase<ProcedimentoQuantidadeThrift, ProcedimentoQuantidadeThrift._Fields>, java.io.Serializable, Cloneable, Comparable<ProcedimentoQuantidadeThrift> {
  private static final org.apache.thrift.protocol.TStruct STRUCT_DESC = new org.apache.thrift.protocol.TStruct("ProcedimentoQuantidadeThrift");

  private static final org.apache.thrift.protocol.TField CO_MS_PROCEDIMENTO_FIELD_DESC = new org.apache.thrift.protocol.TField("coMsProcedimento", org.apache.thrift.protocol.TType.STRING, (short)1);
  private static final org.apache.thrift.protocol.TField QUANTIDADE_FIELD_DESC = new org.apache.thrift.protocol.TField("quantidade", org.apache.thrift.protocol.TType.I32, (short)2);

  private static final Map<Class<? extends IScheme>, SchemeFactory> schemes = new HashMap<Class<? extends IScheme>, SchemeFactory>();
  static {
    schemes.put(StandardScheme.class, new ProcedimentoQuantidadeThriftStandardSchemeFactory());
    schemes.put(TupleScheme.class, new ProcedimentoQuantidadeThriftTupleSchemeFactory());
  }

  private String coMsProcedimento; // optional
  private int quantidade; // optional

  /** The set of fields this struct contains, along with convenience methods for finding and manipulating them. */
  public enum _Fields implements org.apache.thrift.TFieldIdEnum {
    CO_MS_PROCEDIMENTO((short)1, "coMsProcedimento"),
    QUANTIDADE((short)2, "quantidade");

    private static final Map<String, _Fields> byName = new HashMap<String, _Fields>();

    static {
      for (_Fields field : EnumSet.allOf(_Fields.class)) {
        byName.put(field.getFieldName(), field);
      }
    }

    /**
     * Find the _Fields constant that matches fieldId, or null if its not found.
     */
    public static _Fields findByThriftId(int fieldId) {
      switch(fieldId) {
        case 1: // CO_MS_PROCEDIMENTO
          return CO_MS_PROCEDIMENTO;
        case 2: // QUANTIDADE
          return QUANTIDADE;
        default:
          return null;
      }
    }

    /**
     * Find the _Fields constant that matches fieldId, throwing an exception
     * if it is not found.
     */
    public static _Fields findByThriftIdOrThrow(int fieldId) {
      _Fields fields = findByThriftId(fieldId);
      if (fields == null) throw new IllegalArgumentException("Field " + fieldId + " doesn't exist!");
      return fields;
    }

    /**
     * Find the _Fields constant that matches name, or null if its not found.
     */
    public static _Fields findByName(String name) {
      return byName.get(name);
    }

    private final short _thriftId;
    private final String _fieldName;

    _Fields(short thriftId, String fieldName) {
      _thriftId = thriftId;
      _fieldName = fieldName;
    }

    public short getThriftFieldId() {
      return _thriftId;
    }

    public String getFieldName() {
      return _fieldName;
    }
  }

  // isset id assignments
  private static final int __QUANTIDADE_ISSET_ID = 0;
  private byte __isset_bitfield = 0;
  private static final _Fields optionals[] = {_Fields.CO_MS_PROCEDIMENTO,_Fields.QUANTIDADE};
  public static final Map<_Fields, org.apache.thrift.meta_data.FieldMetaData> metaDataMap;
  static {
    Map<_Fields, org.apache.thrift.meta_data.FieldMetaData> tmpMap = new EnumMap<_Fields, org.apache.thrift.meta_data.FieldMetaData>(_Fields.class);
    tmpMap.put(_Fields.CO_MS_PROCEDIMENTO, new org.apache.thrift.meta_data.FieldMetaData("coMsProcedimento", org.apache.thrift.TFieldRequirementType.OPTIONAL, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.STRING)));
    tmpMap.put(_Fields.QUANTIDADE, new org.apache.thrift.meta_data.FieldMetaData("quantidade", org.apache.thrift.TFieldRequirementType.OPTIONAL, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.I32)));
    metaDataMap = Collections.unmodifiableMap(tmpMap);
    org.apache.thrift.meta_data.FieldMetaData.addStructMetaDataMap(ProcedimentoQuantidadeThrift.class, metaDataMap);
  }

  public ProcedimentoQuantidadeThrift() {
  }

  /**
   * Performs a deep copy on <i>other</i>.
   */
  public ProcedimentoQuantidadeThrift(ProcedimentoQuantidadeThrift other) {
    __isset_bitfield = other.__isset_bitfield;
    if (other.isSetCoMsProcedimento()) {
      this.coMsProcedimento = other.coMsProcedimento;
    }
    this.quantidade = other.quantidade;
  }

  public ProcedimentoQuantidadeThrift deepCopy() {
    return new ProcedimentoQuantidadeThrift(this);
  }

  @Override
  public void clear() {
    this.coMsProcedimento = null;
    setQuantidadeIsSet(false);
    this.quantidade = 0;
  }

  public String getCoMsProcedimento() {
    return this.coMsProcedimento;
  }

  public void setCoMsProcedimento(String coMsProcedimento) {
    this.coMsProcedimento = coMsProcedimento;
  }

  public void unsetCoMsProcedimento() {
    this.coMsProcedimento = null;
  }

  /** Returns true if field coMsProcedimento is set (has been assigned a value) and false otherwise */
  public boolean isSetCoMsProcedimento() {
    return this.coMsProcedimento != null;
  }

  public void setCoMsProcedimentoIsSet(boolean value) {
    if (!value) {
      this.coMsProcedimento = null;
    }
  }

  public int getQuantidade() {
    return this.quantidade;
  }

  public void setQuantidade(int quantidade) {
    this.quantidade = quantidade;
    setQuantidadeIsSet(true);
  }

  public void unsetQuantidade() {
    __isset_bitfield = EncodingUtils.clearBit(__isset_bitfield, __QUANTIDADE_ISSET_ID);
  }

  /** Returns true if field quantidade is set (has been assigned a value) and false otherwise */
  public boolean isSetQuantidade() {
    return EncodingUtils.testBit(__isset_bitfield, __QUANTIDADE_ISSET_ID);
  }

  public void setQuantidadeIsSet(boolean value) {
    __isset_bitfield = EncodingUtils.setBit(__isset_bitfield, __QUANTIDADE_ISSET_ID, value);
  }

  public void setFieldValue(_Fields field, Object value) {
    switch (field) {
    case CO_MS_PROCEDIMENTO:
      if (value == null) {
        unsetCoMsProcedimento();
      } else {
        setCoMsProcedimento((String)value);
      }
      break;

    case QUANTIDADE:
      if (value == null) {
        unsetQuantidade();
      } else {
        setQuantidade((Integer)value);
      }
      break;

    }
  }

  public Object getFieldValue(_Fields field) {
    switch (field) {
    case CO_MS_PROCEDIMENTO:
      return getCoMsProcedimento();

    case QUANTIDADE:
      return getQuantidade();

    }
    throw new IllegalStateException();
  }

  /** Returns true if field corresponding to fieldID is set (has been assigned a value) and false otherwise */
  public boolean isSet(_Fields field) {
    if (field == null) {
      throw new IllegalArgumentException();
    }

    switch (field) {
    case CO_MS_PROCEDIMENTO:
      return isSetCoMsProcedimento();
    case QUANTIDADE:
      return isSetQuantidade();
    }
    throw new IllegalStateException();
  }

  @Override
  public boolean equals(Object that) {
    if (that == null)
      return false;
    if (that instanceof ProcedimentoQuantidadeThrift)
      return this.equals((ProcedimentoQuantidadeThrift)that);
    return false;
  }

  public boolean equals(ProcedimentoQuantidadeThrift that) {
    if (that == null)
      return false;

    boolean this_present_coMsProcedimento = true && this.isSetCoMsProcedimento();
    boolean that_present_coMsProcedimento = true && that.isSetCoMsProcedimento();
    if (this_present_coMsProcedimento || that_present_coMsProcedimento) {
      if (!(this_present_coMsProcedimento && that_present_coMsProcedimento))
        return false;
      if (!this.coMsProcedimento.equals(that.coMsProcedimento))
        return false;
    }

    boolean this_present_quantidade = true && this.isSetQuantidade();
    boolean that_present_quantidade = true && that.isSetQuantidade();
    if (this_present_quantidade || that_present_quantidade) {
      if (!(this_present_quantidade && that_present_quantidade))
        return false;
      if (this.quantidade != that.quantidade)
        return false;
    }

    return true;
  }

  @Override
  public int hashCode() {
    List<Object> list = new ArrayList<Object>();

    boolean present_coMsProcedimento = true && (isSetCoMsProcedimento());
    list.add(present_coMsProcedimento);
    if (present_coMsProcedimento)
      list.add(coMsProcedimento);

    boolean present_quantidade = true && (isSetQuantidade());
    list.add(present_quantidade);
    if (present_quantidade)
      list.add(quantidade);

    return list.hashCode();
  }

  @Override
  public int compareTo(ProcedimentoQuantidadeThrift other) {
    if (!getClass().equals(other.getClass())) {
      return getClass().getName().compareTo(other.getClass().getName());
    }

    int lastComparison = 0;

    lastComparison = Boolean.valueOf(isSetCoMsProcedimento()).compareTo(other.isSetCoMsProcedimento());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetCoMsProcedimento()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.coMsProcedimento, other.coMsProcedimento);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetQuantidade()).compareTo(other.isSetQuantidade());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetQuantidade()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.quantidade, other.quantidade);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    return 0;
  }

  public _Fields fieldForId(int fieldId) {
    return _Fields.findByThriftId(fieldId);
  }

  public void read(org.apache.thrift.protocol.TProtocol iprot) throws org.apache.thrift.TException {
    schemes.get(iprot.getScheme()).getScheme().read(iprot, this);
  }

  public void write(org.apache.thrift.protocol.TProtocol oprot) throws org.apache.thrift.TException {
    schemes.get(oprot.getScheme()).getScheme().write(oprot, this);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder("ProcedimentoQuantidadeThrift(");
    boolean first = true;

    if (isSetCoMsProcedimento()) {
      sb.append("coMsProcedimento:");
      if (this.coMsProcedimento == null) {
        sb.append("null");
      } else {
        sb.append(this.coMsProcedimento);
      }
      first = false;
    }
    if (isSetQuantidade()) {
      if (!first) sb.append(", ");
      sb.append("quantidade:");
      sb.append(this.quantidade);
      first = false;
    }
    sb.append(")");
    return sb.toString();
  }

  public void validate() throws org.apache.thrift.TException {
    // check for required fields
    // check for sub-struct validity
  }

  private void writeObject(java.io.ObjectOutputStream out) throws java.io.IOException {
    try {
      write(new org.apache.thrift.protocol.TCompactProtocol(new org.apache.thrift.transport.TIOStreamTransport(out)));
    } catch (org.apache.thrift.TException te) {
      throw new java.io.IOException(te);
    }
  }

  private void readObject(java.io.ObjectInputStream in) throws java.io.IOException, ClassNotFoundException {
    try {
      // it doesn't seem like you should have to do this, but java serialization is wacky, and doesn't call the default constructor.
      __isset_bitfield = 0;
      read(new org.apache.thrift.protocol.TCompactProtocol(new org.apache.thrift.transport.TIOStreamTransport(in)));
    } catch (org.apache.thrift.TException te) {
      throw new java.io.IOException(te);
    }
  }

  private static class ProcedimentoQuantidadeThriftStandardSchemeFactory implements SchemeFactory {
    public ProcedimentoQuantidadeThriftStandardScheme getScheme() {
      return new ProcedimentoQuantidadeThriftStandardScheme();
    }
  }

  private static class ProcedimentoQuantidadeThriftStandardScheme extends StandardScheme<ProcedimentoQuantidadeThrift> {

    public void read(org.apache.thrift.protocol.TProtocol iprot, ProcedimentoQuantidadeThrift struct) throws org.apache.thrift.TException {
      org.apache.thrift.protocol.TField schemeField;
      iprot.readStructBegin();
      while (true)
      {
        schemeField = iprot.readFieldBegin();
        if (schemeField.type == org.apache.thrift.protocol.TType.STOP) { 
          break;
        }
        switch (schemeField.id) {
          case 1: // CO_MS_PROCEDIMENTO
            if (schemeField.type == org.apache.thrift.protocol.TType.STRING) {
              struct.coMsProcedimento = iprot.readString();
              struct.setCoMsProcedimentoIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 2: // QUANTIDADE
            if (schemeField.type == org.apache.thrift.protocol.TType.I32) {
              struct.quantidade = iprot.readI32();
              struct.setQuantidadeIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          default:
            org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
        }
        iprot.readFieldEnd();
      }
      iprot.readStructEnd();
      struct.validate();
    }

    public void write(org.apache.thrift.protocol.TProtocol oprot, ProcedimentoQuantidadeThrift struct) throws org.apache.thrift.TException {
      struct.validate();

      oprot.writeStructBegin(STRUCT_DESC);
      if (struct.coMsProcedimento != null) {
        if (struct.isSetCoMsProcedimento()) {
          oprot.writeFieldBegin(CO_MS_PROCEDIMENTO_FIELD_DESC);
          oprot.writeString(struct.coMsProcedimento);
          oprot.writeFieldEnd();
        }
      }
      if (struct.isSetQuantidade()) {
        oprot.writeFieldBegin(QUANTIDADE_FIELD_DESC);
        oprot.writeI32(struct.quantidade);
        oprot.writeFieldEnd();
      }
      oprot.writeFieldStop();
      oprot.writeStructEnd();
    }

  }

  private static class ProcedimentoQuantidadeThriftTupleSchemeFactory implements SchemeFactory {
    public ProcedimentoQuantidadeThriftTupleScheme getScheme() {
      return new ProcedimentoQuantidadeThriftTupleScheme();
    }
  }

  private static class ProcedimentoQuantidadeThriftTupleScheme extends TupleScheme<ProcedimentoQuantidadeThrift> {

    @Override
    public void write(org.apache.thrift.protocol.TProtocol prot, ProcedimentoQuantidadeThrift struct) throws org.apache.thrift.TException {
      TTupleProtocol oprot = (TTupleProtocol) prot;
      BitSet optionals = new BitSet();
      if (struct.isSetCoMsProcedimento()) {
        optionals.set(0);
      }
      if (struct.isSetQuantidade()) {
        optionals.set(1);
      }
      oprot.writeBitSet(optionals, 2);
      if (struct.isSetCoMsProcedimento()) {
        oprot.writeString(struct.coMsProcedimento);
      }
      if (struct.isSetQuantidade()) {
        oprot.writeI32(struct.quantidade);
      }
    }

    @Override
    public void read(org.apache.thrift.protocol.TProtocol prot, ProcedimentoQuantidadeThrift struct) throws org.apache.thrift.TException {
      TTupleProtocol iprot = (TTupleProtocol) prot;
      BitSet incoming = iprot.readBitSet(2);
      if (incoming.get(0)) {
        struct.coMsProcedimento = iprot.readString();
        struct.setCoMsProcedimentoIsSet(true);
      }
      if (incoming.get(1)) {
        struct.quantidade = iprot.readI32();
        struct.setQuantidadeIsSet(true);
      }
    }
  }

}

